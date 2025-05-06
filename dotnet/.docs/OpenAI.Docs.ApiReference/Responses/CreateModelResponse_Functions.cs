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
    public void CreateModelResponse_Functions()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        ResponseTool getCurrentWeatherFunctionTool = ResponseTool.CreateFunctionTool(
            functionName: "get_current_weather",
            functionDescription: "Get the current weather in a given location",
            functionParameters: BinaryData.FromString("""
                {
                    "type": "object",
                    "properties": {
                        "location": {
                            "type": "string",
                            "description": "The city and state, e.g. San Francisco, CA"
                        },
                        "unit": {"type": "string", "enum": ["celsius", "fahrenheit"]}
                    },
                    "required": ["location", "unit"]
                }
                """
            )
        );

        string userInputText = "What is the weather like in Boston today?";

        ResponseCreationOptions options = new()
        {
            Tools =
            {
                getCurrentWeatherFunctionTool
            },
            ToolChoice = ResponseToolChoice.CreateAutoChoice(),
        };

        OpenAIResponse response = client.CreateResponse(userInputText, options);

        #endregion

        Assert.That(response, Is.Not.Null);
        Assert.That(response.OutputItems, Has.Count.GreaterThan(0));
        Assert.That(response.OutputItems[0], Is.InstanceOf<FunctionCallResponseItem>());
        Assert.That((response.OutputItems[0] as FunctionCallResponseItem).FunctionName, Is.EqualTo("get_current_weather"));
        Assert.That(response.GetOutputText(), Is.Null);
    }
}
