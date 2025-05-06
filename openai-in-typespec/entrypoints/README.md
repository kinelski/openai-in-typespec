## Entrypoints

The generation of OpenAPI v3 documents is assumed to be the default emitter. Simply running the `tsp compile ./entrypoint/<foo>` on your target shouldn't require you to specify the emitter you want to use.

Only `full.openai` and `full.openai.azure` are targets that we would generate OpenAPI v3 documents from. If we wanted to generate, for some reason, a `realtime` specific OpenAPI v3 document, we would have to adjust the `tspconfig.yaml` accordingly.

### Realtime

Currently, we need to add more target language configurations to the `entrypoint/realtime/tspconfig.yaml` file, for now we only have Java. In the interim, we are generating the Java realtime library under `codegen_blackhole/realtime_java` (see the `tspconfig.yaml` for the actual name, it could have changed since the writing of this document). 

To emit any language, we should add a configuration specific to the required emitter. Currently, only `@azure-tools/typespec-java` is configured. One can generate the library by running the following command:

```sh
tsp compile entrypoints/realtime --emit=@azure-tools/typespec-java
```

Eventually, if we need to generate libraries from a location where a `tsp-location.yaml` is defined, I've drafted a guide illustrating how to consume your local copy of this repository into your language repo, follow the instructions in [this document](../docs/tsp-client.md). For a more detailed guide, look at the [official docs.][tsp_location_docs]

### Full OpenAI

From the root of this project `openai-in-typespec` run the following command to generate the full OpenAPI v3 document:

```sh
tsp compile entrypoints/full.openai
```

If you are targeting a specific language, make sure that the emitter is part of the `package.json` file (there might be some fiddling with versions necessary to match peer depedency versions) and then add an entry for your language emitter (if not already present) in the `entrypoints/full.openai/tspconfig.yaml` file, then run the command (in this example we are assuming Java is the target language):

```sh
tsp compile entrypoints/full.openai --emit=@azure-tools/typespec-java
```

### Full Azure OpenAI

For the Azure OpenAI version of the service, instructions are the same as for the [Full OpenAI](#full-openai) section. You only need to adjust the path like so:

```sh
tsp compile entrypoints/full.openai.azure
```

And for a specific language emitter, the same as above, add it as named input `--emit=<emitter-name>`.

[tsp_location_docs]:  [https://github.com/Azure/azure-sdk-tools/tree/main/tools/tsp-client#tsp-locationyaml]

## Adding a new entry point

Adding a new entry point should be simple. Currently there are only a few examples, but essentially the steps boil down to:

1. Create a new folder for your new entry point under `entrypoints`
2. Add a `main.tsp` and `tspconfig.yaml` under the folder
   1. Import a type of server in your `main.tsp` from either `typespec/servers` or `typespec.azure/servers` (Are you targeting a websocket endpoint or a REST one?)
   2. Import in your `main.tsp` file the "feature" folders (for example `realtime`) that you want the entry point to access.
   3. Add the emitters you are expecting to be used in the `tspconfig.yaml` file (there are some folder conventions that should be followed. It's best to copy and paste from a different entrypoint)
   4. If your use case allows for it, configure your emitter like to ` emitter-output-dir: "{project-root}/../../codegen_blackhole/<your_artifact>"`. `codegen_blackhole` is part of the `.gitignore` file.
3. Add some brief documentation as a new section in this `README.md` document

> [!NOTE]
> If you are using a `tsp-location.yaml` and adding multiple folders, you may need to use a `client.tsp` file instead. For more details please refer to this [PR](https://github.com/joseharriaga/openai-in-typespec/pull/325).
