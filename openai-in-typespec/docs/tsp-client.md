## `tsp-client` tool usage guide

This document contains a guide focused on the usage of `tsp-client` for the purposes of working with the TypeSpec definitions in this repository. Check the [tsp-client official docs][tsp-client-docs] for a complete guide.

### Sourcing TSP files from a local folder

In order to use the TSP files from a local repository version you can do the following. Run the command in your SDK project where your `tsp-location.yaml` file is defined

```sh
tsp-client sync --local-spec-repo ~/<path-to-repo>/openai-in-typespec/typespec/realtime/ 
```

You need to have a minimum defined `tsp-location.yaml` file in the folder where you ran the previous command. The file can be as barebones as:

```yaml
directory: openai-in-typespec/typespec/realtime
additionalDirectories:
  - openai-in-typespec/entrypoints/realtime
commit: any-value
repo: any-value
```

The `any-value` will be ignored (you can literally use `any-value` as a value). In this particular example, we are using the `realtime` entry point. The files found under the `additionalDirectories` will be flattened into the resulting folder of importing the files from `directory`

[tsp-client-docs]: https://github.com/Azure/azure-sdk-tools/tree/main/tools/tsp-client
