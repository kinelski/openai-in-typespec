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
    public void CreateModelResponse_WebSearch()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        string userInputText = "What was a positive news story from today?";

        ResponseCreationOptions options = new()
        {
            Tools =
            {
                ResponseTool.CreateWebSearchTool()
            },
        };

        OpenAIResponse response = client.CreateResponse(userInputText, options);

        Console.WriteLine(response.GetOutputText());

        #endregion

        Assert.That(response, Is.Not.Null);
        Assert.That(response.OutputItems, Has.Count.GreaterThan(0));
        Assert.That(response.OutputItems[0], Is.InstanceOf<WebSearchCallResponseItem>());
        Assert.That(response.GetOutputText(), Is.Not.Null.Or.Empty);
    }
}
