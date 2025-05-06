#!/usr/bin/env node
import fs from "fs";
import path from "path";
import { validateOpenAPISpec } from "./validate-openapi.js";
import { performEndpointValidations } from "./validate-endpoints.js";

// Parse command-line arguments
function parseArgs() {
  const args = process.argv.slice(2);
  let directory = null;
  let endpointsConfigPath = null;

  for (let i = 0; i < args.length; i++) {
    if (args[i] === "--directory" || args[i] === "-d") {
      directory = args[i + 1];
      i++;
    } else if (args[i] === "--endpoints-config" || args[i] === "-e") {
      endpointsConfigPath = args[i + 1];
      i++;
    }
  }

  if (!directory) {
    console.error("Error: Directory path is required (--directory or -d)");
    process.exit(1);
  }

  return { directory, endpointsConfigPath };
}

// Find YAML file in the directory
function findYamlFile(directory) {
  const files = fs.readdirSync(directory);
  const yamlFile = files.find(file => 
    file.endsWith(".yaml") || file.endsWith(".yml")
  );
  
  if (!yamlFile) {
    console.error("Error: No YAML file found in the specified directory");
    process.exit(1);
  }
  
  return path.join(directory, yamlFile);
}

// Main function
async function main() {
  try {
    const { directory, endpointsConfigPath } = parseArgs();
    
    // Find the YAML file
    const yamlFilePath = findYamlFile(directory);
    console.log(`Found YAML file: ${yamlFilePath}`);
    
    // Step 1: Validate OpenAPI spec
    console.log("Validating OpenAPI specification...");
    await validateOpenAPISpec(yamlFilePath);
    
    // Step 2: If endpoints config provided, perform endpoint validations
    if (endpointsConfigPath) {
      if (!fs.existsSync(endpointsConfigPath)) {
        console.warn(`Warning: Endpoints config file not found: ${endpointsConfigPath}`);
      }
      else {
        console.log(`Found endpoints config file: ${endpointsConfigPath}`);
        const endpointValidationResult = await performEndpointValidations(yamlFilePath, endpointsConfigPath);
        
        if (!endpointValidationResult.success) {
            console.error("Endpoint validation failed:");
            endpointValidationResult.errors.forEach(error => console.error(`- ${error}`));
            process.exit(1);
          }
           
        console.log("✔️  Endpoint validations successful");
      }
    }

  } catch (error) {
    console.error("Validation failed:", error.message);
    process.exit(1);
  }

  console.log("✅ Validation run complete");
}

main();