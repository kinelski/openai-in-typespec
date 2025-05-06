import "@typespec/http";
import "@typespec/openapi";
import "@typespec/versioning";

import "../common";
import "./models.tsp";

using TypeSpec.Http;
using TypeSpec.OpenAPI;
using TypeSpec.Versioning;

namespace AzureOpenAI;

@added(AzureOpenAIServiceApiVersion.v2025_03_01_preview)
@route("/files")
interface AzureFiles {
  @post
  @operationId("createFile")
  @tag("Files")
  @summary("""
    Upload a file that can be used across various endpoints. The size of all the files uploaded by
    one organization can be up to 100 GB.
    
    The size of individual files can be a maximum of 512 MB or 2 million tokens for Assistants. See
    the [Assistants Tools guide](/docs/assistants/tools) to learn more about the types of files
    supported. The Fine-tuning API only supports `.jsonl` files.
    
    Please [contact us](https://help.openai.com/) if you need to increase these storage limits.
    """)
  createFile(
    @header accept: "application/json",
    @header contentType: "multipart/form-data",
    @body requestBody: AzureCreateFileRequest,
  ): AzureOpenAIFile | OpenAI.ErrorResponse;

  @get
  @operationId("listFiles")
  @tag("Files")
  @summary("Returns a list of files that belong to the user's organization.")
  listFiles(
    @header accept: "application/json",

    // TODO: This is just a string in the OpenAPI spec.
    /** Only return files with the given purpose. */
    @query purpose?: string,
  ): AzureListFilesResponse | OpenAI.ErrorResponse;

  @route("{file_id}")
  @get
  @operationId("retrieveFile")
  @tag("Files")
  @summary("Returns information about a specific file.")
  retrieveFile(
    @header accept: "application/json",

    /** The ID of the file to use for this request. */
    @path file_id: string,
  ): AzureOpenAIFile | OpenAI.ErrorResponse;

  @route("{file_id}")
  @delete
  @operationId("deleteFile")
  @tag("Files")
  @summary("Delete a file")
  deleteFile(
    @header accept: "application/json",

    /** The ID of the file to use for this request. */
    @path file_id: string,
  ): OpenAI.DeleteFileResponse | OpenAI.ErrorResponse;

  @route("{file_id}/content")
  @get
  @operationId("downloadFile")
  @tag("Files")
  @summary("Returns the contents of the specified file.")
  downloadFile(
    @header accept: "application/json",

    /** The ID of the file to use for this request. */
    @path file_id: string,
  ): bytes | OpenAI.ErrorResponse;
}
