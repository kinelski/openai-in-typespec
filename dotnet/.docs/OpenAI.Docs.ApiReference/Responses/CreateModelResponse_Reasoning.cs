#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;

using OpenAI.Responses;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class ResponseDocs
{
    [Test]
    public void CreateModelResponse_Reasoning()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "o3-mini",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        string userInputText = "How much wood would a woodchuck chuck?";

        ResponseCreationOptions options = new()
        {
            ReasoningOptions = new()
            {
                ReasoningEffortLevel = ResponseReasoningEffortLevel.High,
            },
        };

        OpenAIResponse response = client.CreateResponse(userInputText, options);

        Console.WriteLine(response.GetOutputText());

        #endregion

        Assert.That(response, Is.Not.Null);
        Assert.That(response.OutputItems, Has.Count.GreaterThan(0));
        Assert.That(response.OutputItems[0], Is.InstanceOf<ReasoningResponseItem>());
        Assert.That(response.ReasoningOptions.ReasoningEffortLevel, Is.EqualTo(ResponseReasoningEffortLevel.High));
        Assert.That(response.GetOutputText(), Is.Not.Null.Or.Empty);
    }
}
