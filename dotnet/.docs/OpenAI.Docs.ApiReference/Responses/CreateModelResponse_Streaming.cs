#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;
using System.ClientModel;
using System.Threading.Tasks;

using OpenAI.Responses;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class ResponseDocs
{
    [Test]
    public async Task CreateModelResponse_Streaming()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        string userInputText = "Hello!";

        ResponseCreationOptions options = new()
        {
            Instructions = "You are a helpful assistant.",
        };

        AsyncCollectionResult<StreamingResponseUpdate> responseUpdates = client.CreateResponseStreamingAsync(userInputText, options);

        await foreach (StreamingResponseUpdate responseUpdate in responseUpdates)
        {
            if (responseUpdate is StreamingResponseOutputTextDeltaUpdate outputTextDeltaUpdate)
            {
                Console.Write(outputTextDeltaUpdate.Delta);
            }
        }

        #endregion
    }
}
