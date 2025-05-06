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
    public void CreateModelResponse_TextInput()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        OpenAIResponse response = client.CreateResponse("Tell me a three sentence bedtime story about a unicorn.");

        Console.WriteLine(response.GetOutputText());

        #endregion

        Assert.That(response, Is.Not.Null);
        Assert.That(response.OutputItems, Has.Count.GreaterThan(0));
        Assert.That(response.GetOutputText(), Is.Not.Null.Or.Empty);
    }
}
