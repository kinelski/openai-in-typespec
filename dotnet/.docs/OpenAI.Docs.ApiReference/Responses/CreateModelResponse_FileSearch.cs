#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;

using OpenAI.Responses;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class ResponseDocs
{
    [Ignore("Requires an existing vector store.")]
    [Test]
    public void CreateModelResponse_FileSearch()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        string userInputText = "What are the attributes of an ancient brown dragon?";

        ResponseCreationOptions options = new()
        {
            Tools =
            {
                ResponseTool.CreateFileSearchTool(
                    vectorStoreIds: ["vs_1234567890"],
                    maxResultCount: 20
                )
            },
        };

        OpenAIResponse response = client.CreateResponse(userInputText, options);

        Console.WriteLine(response.GetOutputText());

        #endregion

        Assert.That(response, Is.Not.Null);
        Assert.That(response.OutputItems, Has.Count.GreaterThan(0));
        Assert.That(response.GetOutputText(), Is.Not.Null.Or.Empty);
    }
}
