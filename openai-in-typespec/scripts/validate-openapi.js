import fs from 'fs';
import path from 'path';
import yaml from 'js-yaml';
import Ajv from 'ajv';
import addFormats from 'ajv-formats';
import { fileURLToPath } from 'url';

// Get the directory name in ES modules
const __filename = fileURLToPath(import.meta.url);
const __dirname = path.dirname(__filename);

// Schema paths are relative to script directory
const OpenAPI3Schema = path.join(process.cwd(), 'openai-in-typespec/validation/schemas', 'openapi-3.0.json');
const OpenAPI31Schema = path.join(process.cwd(), 'openai-in-typespec/validation/schemas', 'openapi-3.1.json');

// Parse command-line arguments
function parseArgs() {
  const args = process.argv.slice(2);
  let directory = null;
  let specFilePath = null;

  for (let i = 0; i < args.length; i++) {
    if (args[i] === "--directory" || args[i] === "-d") {
      directory = args[i + 1];
      i++;
    } else if (args[i] === "--file" || args[i] === "-f") {
      specFilePath = args[i + 1];
      i++;
    }
  }

  if (!directory && !specFilePath) {
    console.error("Error: Directory path or file path is required (--directory/-d or --file/-f)");
    process.exit(1);
  }

  return { directory, specFilePath };
}

/**
 * Find latest version of a file in a directory
 * @param {string} directory - Directory to search in
 * @returns {string} Path to the latest version file
 */
function findLatestFile(directory) {
  try {
    // Get all files in the directory
    const files = fs.readdirSync(directory)
      .filter(file => file.endsWith('.yaml'));
    
    if (files.length === 0) {
      console.error(`No matching files found in ${directory}`);
      return null;
    }
    
    // Sort files by name in descending order (latest version typically has higher name)
    files.sort().reverse();
    
    // Return the path to the latest file
    const latestFile = path.join(directory, files[0]);
    console.log(`Found latest file: ${latestFile}`);
    return latestFile;
  } catch (error) {
    console.error(`Error finding latest file: ${error.message}`);
    return null;
  }
}

/**
 * Function to validate OpenAPI spec
 * @param {string} filePath - Path to the generated YAML file
 */
function validateOpenAPISpec(filePath) {
  try {
    // Resolve the file path relative to current directory
    const resolvedPath = path.resolve(process.cwd(), filePath);
    
    console.log('Module running from:', __dirname);
    console.log('Current working directory:', process.cwd());
    console.log('Input file path:', filePath);
    console.log('Resolved file path:', resolvedPath);
    
    // Read and parse the YAML file
    const fileContent = fs.readFileSync(resolvedPath, 'utf8');
    
    // Load and parse the appropriate schema based on version first
    const openApiSpec = yaml.load(fileContent);
    const openApiVersion = openApiSpec.openapi;
    const schemaPath = openApiVersion.startsWith('3.1') ? OpenAPI31Schema : OpenAPI3Schema;
    
    // Load the correct schema version
    const schema = fs.readFileSync(schemaPath, 'utf8');
    const schemaObj = JSON.parse(schema);
    
    // Initialize AJV with better defaults
    const ajv = new Ajv({
        strict: false,
        allErrors: true,
        verbose: true,
        logger: false, // Suppress internal logging
        validateFormats: true
    });
    
    addFormats(ajv);
    
    // Compile and validate against the schema
    const validate = ajv.compile(schemaObj);
    const valid = validate(openApiSpec);
    
    if (valid) {
        console.log('✔️  OpenAPI specification is valid!');
        return true;
    } else {
        console.error('❌ OpenAPI specification has validation errors:');
        console.error('----------------------------------------');
        validate.errors.forEach((error, index) => {
            console.error(`Error ${index + 1}:`);
            console.error(`  Path: ${error.instancePath || '/'}`);
            console.error(`  Message: ${error.message}`);
            if (Object.keys(error.params).length > 0) {
                console.error('  Details:', JSON.stringify(error.params, null, 2));
            }
            console.error('----------------------------------------');
        });
        return false;
    }
  } catch (error) {
    console.error('Error during validation:', error.message);
    if (error.code === 'ENOENT') {
      console.error('File not found. Please check if the path is correct and the file exists.');
    }
    return false;
  }
}

// export for use in other scripts
export { validateOpenAPISpec, findLatestFile };

// Main script execution

let {openapiFilePath, directory} = parseArgs();
if (openapiFilePath) {
  // User provided a specific file
} else if (directory) {
  // User provided a directory, try to find the latest file
  const latestSpec = findLatestFile(path.resolve(process.cwd(), directory));
  
  if (latestSpec) {
    openapiFilePath = latestSpec;
    console.log('Using latest OpenAPI spec file:', openapiFilePath);
  } else {
    console.log('No file found in the specified directory.');
  }
}
else {
  console.error('No file or directory provided. Checking default directory for generated Azure OpenAI.');
  directory = path.join(process.cwd(), 'openai-in-typespec/generated-openapi3/full.azure.openai');
  openapiFilePath = findLatestFile(directory);
  if (openapiFilePath) {
    console.log('Using latest OpenAPI spec file:', openapiFilePath);
  } else {
    console.error('No file found in the default directory. Exiting.');
    process.exit(1);
  }
}

// Run directly (not imported)
validateOpenAPISpec(openapiFilePath);