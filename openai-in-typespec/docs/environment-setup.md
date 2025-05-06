# TypeSpec Environment Setup Guide

This guide explains how to set up your development environment for TypeSpec YAML generation and validation.

## Prerequisites

- Node.js 20.19.0 or later
- npm 10.0.0 or later
- Git

## Quick Start

### Using the Dev Container (Recommended)

If you have VS Code with the Remote Containers extension installed:

1. Clone the repository
2. Open the repository in VS Code
3. When prompted, click "Reopen in Container"
4. The container will be built with all necessary dependencies

### Manual Setup

#### Using the Setup Script

```bash
# Clone the repository
git clone <repository-url>
cd <repository-directory>

# Run the setup script
chmod +x scripts/setup-env.sh
./scripts/setup-env.sh
```

#### Manual Setup

```bash
# Install NVM (Node Version Manager)
curl -o- https://raw.githubusercontent.com/nvm-sh/nvm/v0.39.5/install.sh | bash
source ~/.nvm/nvm.sh

# Install and use the correct Node version
nvm install 20.19.0
nvm use 20.19.0

# Install TypeSpec compiler globally
npm install -g @typespec/compiler

# Install project dependencies
npm install
```

## Local Development Workflow

### This will compile your TypeSpec files and output OpenAPI 3.0 YAML.

```bash
npm run generate
```

This will validate generated OpenAPI 3.0 YAML.

### Validating YAML Compatibility

```bash
npm run validate
```
