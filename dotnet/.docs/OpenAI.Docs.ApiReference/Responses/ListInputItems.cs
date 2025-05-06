#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;
using System.ClientModel;

using OpenAI.Responses;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class ResponseDocs
{
    [Ignore("Requires an existing response.")]
    [Test]
    public void ListInputItems()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o-mini",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        CollectionResult<ResponseItem> inputItems = client.GetResponseInputItems(responseId: "resp_123");

        foreach (ResponseItem inputItem in inputItems)
        {
            Console.WriteLine($"ID: {inputItem.Id}");
        }

        #endregion
    }
}
