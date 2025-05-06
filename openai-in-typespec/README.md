## Azure OpenAI Layered spec

The folder structure in this repository contains the TypeSpec (TSP) definitions for:

| Folder| Description|
| --- | --- |
|`entrypoints`|Entry points for artifact generation, see [entry points README](./entrypoints/README.md#entrypoints).|
|`generated-openapi3`| OpenAPI v3 documents matching applicable entry points.|
|`typespec` | OpenAI TypeSpec definition|
|`typespec.azure/` | Azure layer TypeSpec definition|

### Setup for local development

#### Using devcontainer

The `.devcontainer` directory in the repo root has been configured for working with the TypeSpec project to make changes or generate the latest OpenAPI spec.

To open the repository in a devcontainer with VS Code:

1. Ensure you have [VS Code](https://code.visualstudio.com/) installed
2. Install the [Remote - Containers](https://marketplace.visualstudio.com/items?itemName=ms-vscode-remote.remote-containers) extension
3. Clone the repository to your local machine
4. Open VS Code and select "File > Open Folder..." to open the cloned repository
5. When prompted, click "Reopen in Container" or use the command palette (F1) and select "Remote-Containers: Reopen in Container"
6. VS Code will build and start the devcontainer with all required dependencies

Once the devcontainer is running, you can use the terminal in VS Code to run TypeSpec commands and the preconfigured scripts in `package.json` at the repository root.

A few useful commands for getting started:

- `npm run generate` will compile all TSP projects and generate OpenAPI specs for OpenAI and Azure OpenAI
- `npm run validate` will run validation scripts against the latest OpenAI specs for OpenAI and AzureOpenAI
- Azure-only and OpenAI-only scripts are defined for more targeted execution, see [package.json](../package.json)

#### Manual

In the root of this repository you will find the `package.json` file that contains the dependencies required to run this project. 

If you have TypeSpec somehow already installed you can simply run 

```sh
tsp install
```

Then you will be able to run

```sh
tsp compile openai-in-typespec/typespec/client.tsp
tsp compile openai-in-typespec/typespec.azure/client.tsp
```

If the OpenAPI v3 files are somehow out of date or you've introduced new changes in TypeSpec, you should see changes in the files under `openai-in-typespec/openapi3` and `openai-in-typespec/openapi3.azure`.

If you want to emit something other than OpenAPI v3 documents, see [the entry point README](./entrypoints/README.md) for more details.


### Version details

Unless otherwise noted, `external-specs/latest.yaml` should match the files generated here.

See https://dev.azure.com/project-argos/Sorento/_wiki/wikis/Sorento.wiki/3021/Generate-OpenAI's-YAML-Spec for instructions on generating a spec from composite sources in the Sorento or Mumford export pipelines.

