using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace OpenAI.Responses;

[CodeGenType("Item")]
public partial class ResponseItem
{
    public static MessageResponseItem CreateUserMessageItem(IEnumerable<ResponseContentPart> contentParts)
    {
        Argument.AssertNotNullOrEmpty(contentParts, nameof(contentParts));
        return new InternalResponsesUserMessage(contentParts);
    }

    public static MessageResponseItem CreateUserMessageItem(string inputTextContent)
    {
        Argument.AssertNotNull(inputTextContent, nameof(inputTextContent));
        return new InternalResponsesUserMessage(
            internalContent: [ResponseContentPart.CreateInputTextPart(inputTextContent)]);
    }

    public static MessageResponseItem CreateDeveloperMessageItem(IEnumerable<ResponseContentPart> contentParts)
    {
        Argument.AssertNotNull(contentParts, nameof(contentParts));
        return new InternalResponsesDeveloperMessage(contentParts);
    }

    public static MessageResponseItem CreateDeveloperMessageItem(string inputTextContent)
    {
        Argument.AssertNotNull(inputTextContent, nameof(inputTextContent));
        return new InternalResponsesDeveloperMessage(
            internalContent: [ResponseContentPart.CreateInputTextPart(inputTextContent)]);
    }

    public static MessageResponseItem CreateSystemMessageItem(IEnumerable<ResponseContentPart> contentParts)
    {
        Argument.AssertNotNull(contentParts, nameof(contentParts));
        return new InternalResponsesSystemMessage(contentParts);
    }

    public static MessageResponseItem CreateSystemMessageItem(string inputTextContent)
    {
        Argument.AssertNotNull(inputTextContent, nameof(inputTextContent));
        return new InternalResponsesSystemMessage(
            internalContent: [ResponseContentPart.CreateInputTextPart(inputTextContent)]);
    }

    public static MessageResponseItem CreateAssistantMessageItem(
        IEnumerable<ResponseContentPart> contentParts)
    {
        Argument.AssertNotNull(contentParts, nameof(contentParts));
        return new InternalResponsesAssistantMessage(contentParts);
    }

    public static MessageResponseItem CreateAssistantMessageItem(
        string outputTextContent,
        IEnumerable<ResponseMessageAnnotation> annotations = null)
    {
        Argument.AssertNotNull(outputTextContent, nameof(outputTextContent));
        return new InternalResponsesAssistantMessage(
            internalContent:
            [
                new InternalItemContentOutputText(annotations ?? [], outputTextContent),
            ]);
    }

    [Experimental("OPENAICUA001")]
    public static ResponseItem CreateComputerCallItem(string callId, ComputerCallAction action, IEnumerable<ComputerCallSafetyCheck> pendingSafetyChecks)
    {
        return new ComputerCallResponseItem(callId, action, pendingSafetyChecks);
    }

    [Experimental("OPENAICUA001")]
    public static ResponseItem CreateComputerCallOutputItem(string callId, IList<ComputerCallSafetyCheck> acknowledgedSafetyChecks, Uri screenshotImageUri)
    {
        ComputerCallOutputResponseItem item = new(
            callId,
            ComputerOutput.CreateScreenshotOutput(screenshotImageUri));
        foreach (ComputerCallSafetyCheck safetyCheck in acknowledgedSafetyChecks ?? [])
        {
            item.AcknowledgedSafetyChecks.Add(safetyCheck);
        }
        return item;
    }

    [Experimental("OPENAICUA001")]
    public static ResponseItem CreateComputerCallOutputItem(string callId, IList<ComputerCallSafetyCheck> acknowledgedSafetyChecks, string screenshotImageFileId)
    {
        ComputerCallOutputResponseItem item = new(
            callId,
            ComputerOutput.CreateScreenshotOutput(screenshotImageFileId));
        foreach (ComputerCallSafetyCheck safetyCheck in acknowledgedSafetyChecks ?? [])
        {
            item.AcknowledgedSafetyChecks.Add(safetyCheck);
        }
        return item;
    }

    [Experimental("OPENAICUA001")]
    public static ResponseItem CreateComputerCallOutputItem(string callId, IList<ComputerCallSafetyCheck> acknowledgedSafetyChecks, BinaryData screenshotImageBytes, string screenshotImageBytesMediaType)
    {
        ComputerCallOutputResponseItem item = new(
            callId,
            ComputerOutput.CreateScreenshotOutput(screenshotImageBytes, screenshotImageBytesMediaType));
        foreach (ComputerCallSafetyCheck safetyCheck in acknowledgedSafetyChecks ?? [])
        {
            item.AcknowledgedSafetyChecks.Add(safetyCheck);
        }
        return item;
    }

    public static WebSearchCallResponseItem CreateWebSearchCallItem()
    {
        return new WebSearchCallResponseItem();
    }

    public static FileSearchCallResponseItem CreateFileSearchCallItem(
        IEnumerable<string> queries,
        IEnumerable<FileSearchCallResult> results)
    {
        FileSearchCallResponseItem item = new(queries)
        {
            Results = results.ToList(),
        };
        return item;
    }

    public static FunctionCallResponseItem CreateFunctionCallItem(string callId, string functionName, BinaryData functionArguments)
    {
        return new FunctionCallResponseItem(callId, functionName, functionArguments);
    }

    public static FunctionCallOutputResponseItem CreateFunctionCallOutputItem(string callId, string functionOutput)
    {
        return new FunctionCallOutputResponseItem(callId, functionOutput);
    }

    public static ReasoningResponseItem CreateReasoningItem(IEnumerable<string> summaryTextParts)
    {
        return new ReasoningResponseItem(summaryTextParts);
    }

    public static ReferenceResponseItem CreateReferenceItem(string id)
    {
        return new ReferenceResponseItem(id);
    }
}
