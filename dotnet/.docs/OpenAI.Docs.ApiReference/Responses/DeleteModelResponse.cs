#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;

using OpenAI.Responses;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class ResponseDocs
{
    [Ignore("Requires an existing response.")]
    [Test]
    public void DeleteModelResponse()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        ResponseDeletionResult deletionResult = client.DeleteResponse(responseId: "resp_123");

        #endregion
    }
}
