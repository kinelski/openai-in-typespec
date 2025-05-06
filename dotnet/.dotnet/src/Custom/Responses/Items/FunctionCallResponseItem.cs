using System;

namespace OpenAI.Responses;

// CUSTOM:
// - Renamed.
// - Customized serialization of the BinaryData-as-string FunctionArguments
[CodeGenType("FunctionToolCall")]
[CodeGenSerialization(nameof(FunctionArguments), SerializationValueHook = nameof(SerializeFunctionArgumentsValue), DeserializationValueHook = nameof(DeserializeFunctionArgumentsValue))]
public partial class FunctionCallResponseItem
{
    // CUSTOM: Renamed.
    [CodeGenMember("Name")]
    public string FunctionName { get; set; }

    // CUSTOM:
    // - Renamed.
    // - Changed type from string to BinaryData.
    [CodeGenMember("Arguments")]
    public BinaryData FunctionArguments { get; set; }

    // CUSTOM: Retain optionality of OpenAPI read-only property value
    [CodeGenMember("Status")]
    public FunctionCallStatus? Status { get; }
}