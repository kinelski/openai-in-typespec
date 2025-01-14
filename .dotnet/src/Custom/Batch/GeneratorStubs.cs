namespace OpenAI.Batch;

[CodeGenModel("Batch")]
internal partial class InternalBatchJob { private readonly object Object; }

[CodeGenModel("InternalBatchJobStatus")]
internal readonly partial struct InternalBatchJobStatus {}

[CodeGenModel("BatchErrors")]
internal partial class InternalBatchErrors {}

[CodeGenModel("BatchErrorsDatum")]
internal partial class InternalBatchError { }

[CodeGenModel("BatchErrorsObject")]
internal readonly partial struct InternalBatchErrorsObject {}

[CodeGenModel("BatchRequestCounts")]
internal readonly partial struct InternalBatchRequestCounts {}

[CodeGenModel("ListBatchesResponse")]
internal partial class InternalListBatchesResponse { private readonly object Object; }

[CodeGenModel("CreateBatchRequestCompletionWindow")]
internal readonly partial struct InternalBatchCompletionTimeframe {}

[CodeGenModel("CreateBatchRequest")]
internal readonly partial struct InternalCreateBatchRequest {}

[CodeGenModel("InternalCreateBatchRequestEndpoint")]
internal readonly partial struct InternalBatchOperationEndpoint {}
