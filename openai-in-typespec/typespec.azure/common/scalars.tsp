namespace AzureOpenAI;

@doc("API version for the request")
@pattern("^\\d{4}-\\d{2}-\\d{2}(-preview)?$")
@example("2024-12-01-preview")
scalar ApiVersion extends string;
