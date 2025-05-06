import fs from 'fs';
import path from 'path';
import yaml from 'js-yaml';

// Parse command-line arguments
function parseArgs() {
    const args = process.argv.slice(2);
    let endpointsConfigPath = null;
    let specFilePath = null;
  
    for (let i = 0; i < args.length; i++) {
      if (args[i] === "--endpointsConfigPath" || args[i] === "-e") {
        endpointsConfigPath = args[i + 1];
        i++;
      } else if (args[i] === "--file" || args[i] === "-f") {
        specFilePath = args[i + 1];
        i++;
      }
    }
  
    if (!endpointsConfigPath || !specFilePath) {
      console.error("Error: endpoints config file path and spec file path are required (--endpointsConfigPath/-e and --file/-f)");
      process.exit(1);
    }
  
    return { endpointsConfigPath, specFilePath };
}

/**
 * Performs specific validations on the generated YAML content
 * @param {Object} yamlData - YAML file path
 * @returns {Object} - Custom validation results
 */
function performEndpointValidations(yamlFile, yamlConfigPath) {
    const errors = [];

    console.log('Using YAML file:', yamlFile);
    const resolvedPath = path.resolve(process.cwd(), yamlFile);
    console.log('Resolved YAML file path:', resolvedPath);

    // check if the file exists
    if (!fs.existsSync(resolvedPath)) {
        errors.push(`YAML file not found: ${resolvedPath}`);
        return { success: false, errors };
    }

    // Parse YAML after ensuring schema is valid
    const yamlContent = fs.readFileSync(resolvedPath, 'utf8');
    const yamlData = yaml.load(yamlContent);
    
    // Check for essential endpoints, load from config file if available
    let essentialEndpoints = [];
    try {
        const configPath = path.resolve(process.cwd(), yamlConfigPath);
        console.log('Using config file:', configPath);

        // check if the config file exists
        if (!fs.existsSync(configPath)) {
            errors.push(`Config file not found: ${configPath}`);
            return { success: false, errors };
        }

        const configContent = fs.readFileSync(configPath, 'utf8');
        const config = JSON.parse(configContent);
        essentialEndpoints = config.essentialEndpoints || [];
    } catch (error) {
        console.warn(`Warning: Could not load endpoints config file: ${error.message}`);
        
        // Fall back to default endpoints if config file cannot be loaded
        essentialEndpoints = ['/chat/completions', '/completions', '/models'];
    }

    const definedPaths = Object.keys(yamlData.paths || {});
    const missingEndpoints = essentialEndpoints.filter(endpoint => !definedPaths.some(path => path.endsWith(endpoint)));

    if (missingEndpoints.length > 0) {
      errors.push(`Missing essential OpenAI endpoints: ${missingEndpoints.join(', ')}`);
    }

    return errors.length > 0 
      ? { success: false, errors } 
      : { success: true };
}

// export for use in other scripts
export { performEndpointValidations };

// Main script execution
let { endpointsConfigPath, specFilePath } = parseArgs();
const yamlFile = path.resolve(process.cwd(), specFilePath);
const yamlConfigPath = path.resolve(process.cwd(), endpointsConfigPath);
if(!fs.existsSync(yamlFile)) {
    console.error(`YAML file file not found: ${yamlFile}`);
    process.exit(1);
}
if (!fs.existsSync(yamlConfigPath)) {
    console.error(`Config file not found: ${yamlConfigPath}`);
    process.exit(1);
}
performEndpointValidations(yamlFile, yamlConfigPath);
