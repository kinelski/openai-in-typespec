﻿using NUnit.Framework;
using OpenAI.Chat;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Samples
{
    public partial class ChatSamples
    {
        #region
        private static string GetCurrentLocation()
        {
            // Call the location API here.
            return "San Francisco";
        }

        private static string GetCurrentWeather(string location, string unit = "celsius")
        {
            // Call the weather API here.
            return $"31 {unit}";
        }
        #endregion

        #region
        private const string GetCurrentLocationFunctionName = "get_current_location";

        private const string GetCurrentWeatherFunctionName = "get_current_weather";

        private static readonly ChatTool getCurrentLocationFunction = ChatTool.CreateFunctionTool(
            functionName: GetCurrentLocationFunctionName,
            functionDescription: "Get the user's current location"
        );

        private static readonly ChatTool getCurrentWeatherFunction = ChatTool.CreateFunctionTool(
            functionName: GetCurrentWeatherFunctionName,
            functionDescription: "Get the current weather in a given location",
            functionParameters: BinaryData.FromString("""
                {
                    "type": "object",
                    "properties": {
                        "location": {
                            "type": "string",
                            "description": "The city and state, e.g. Boston, MA"
                        },
                        "unit": {
                            "type": "string",
                            "enum": [ "celsius", "fahrenheit" ],
                            "description": "The temperature unit to use. Infer this from the specified location."
                        }
                    },
                    "required": [ "location" ]
                }
                """)
        );
        #endregion

        [Test]
        [Ignore("Compilation validation only")]
        public void Sample03_FunctionCalling()
        {
            ChatClient client = new("gpt-3.5-turbo", Environment.GetEnvironmentVariable("OPENAI_API_KEY"));

            #region
            List<ChatMessage> messages = [
                new SystemChatMessage(
                   "Don't make assumptions about what values to plug into functions."
                   + " Ask for clarification if a user request is ambiguous."),
                new UserChatMessage("What's the weather like today?"),
            ];

            ChatCompletionOptions options = new()
            {
                Tools = { getCurrentLocationFunction, getCurrentWeatherFunction },
            };
            #endregion

            #region
            bool requiresAction;

            do
            {
                requiresAction = false;
                ChatCompletion chatCompletion = client.CompleteChat(messages, options);

                switch (chatCompletion.FinishReason)
                {
                    case ChatFinishReason.Stop:
                        {
                            // Add the assistant message to the conversation history.
                            messages.Add(new AssistantChatMessage(chatCompletion));
                            break;
                        }

                    case ChatFinishReason.ToolCalls:
                        {
                            // First, add the assistant message with tool calls to the conversation history.
                            messages.Add(new AssistantChatMessage(chatCompletion));

                            // Then, add a new tool message for each tool call that is resolved.
                            foreach (ChatToolCall toolCall in chatCompletion.ToolCalls)
                            {
                                switch (toolCall.FunctionName)
                                {
                                    case GetCurrentLocationFunctionName:
                                        {
                                            string toolResult = GetCurrentLocation();
                                            messages.Add(new ToolChatMessage(toolCall.Id, toolResult));
                                            break;
                                        }

                                    case GetCurrentWeatherFunctionName:
                                        {
                                            // The arguments that the model wants to use to call the function are specified as a
                                            // stringified JSON object based on the schema defined in the tool definition. Note that
                                            // the model may hallucinate arguments too. Consequently, it is important to do the
                                            // appropriate parsing and validation before calling the function.
                                            using JsonDocument argumentsJson = JsonDocument.Parse(toolCall.FunctionArguments);
                                            bool hasLocation = argumentsJson.RootElement.TryGetProperty("location", out JsonElement location);
                                            bool hasUnit = argumentsJson.RootElement.TryGetProperty("unit", out JsonElement unit);

                                            if (!hasLocation)
                                            {
                                                throw new ArgumentNullException(nameof(location), "The location argument is required.");
                                            }

                                            string toolResult = hasUnit
                                                ? GetCurrentWeather(location.GetString(), unit.GetString())
                                                : GetCurrentWeather(location.GetString());
                                            messages.Add(new ToolChatMessage(toolCall.Id, toolResult));
                                            break;
                                        }

                                    default:
                                        {
                                            // Handle other unexpected calls.
                                            throw new NotImplementedException();
                                        }
                                }
                            }

                            requiresAction = true;
                            break;
                        }

                    case ChatFinishReason.Length:
                        throw new NotImplementedException("Incomplete model output due to MaxTokens parameter or token limit exceeded.");

                    case ChatFinishReason.ContentFilter:
                        throw new NotImplementedException("Omitted content due to a content filter flag.");

                    case ChatFinishReason.FunctionCall:
                        throw new NotImplementedException("Deprecated in favor of tool calls.");

                    default:
                        throw new NotImplementedException(chatCompletion.FinishReason.ToString());
                }
            } while (requiresAction);
            #endregion

            #region
            foreach (ChatMessage requestMessage in messages)
            {
                switch (requestMessage)
                {
                    case SystemChatMessage systemMessage:
                        Console.WriteLine($"[SYSTEM]:");
                        Console.WriteLine($"{systemMessage.Content[0].Text}");
                        Console.WriteLine();
                        break;

                    case UserChatMessage userMessage:
                        Console.WriteLine($"[USER]:");
                        Console.WriteLine($"{userMessage.Content[0].Text}");
                        Console.WriteLine();
                        break;

                    case AssistantChatMessage assistantMessage when assistantMessage.Content.Count > 0:
                        Console.WriteLine($"[ASSISTANT]:");
                        Console.WriteLine($"{assistantMessage.Content[0].Text}");
                        Console.WriteLine();
                        break;

                    case ToolChatMessage:
                        // Do not print any tool messages; let the assistant summarize the tool results instead.
                        break;

                    default:
                        break;
                }
            }
            #endregion
        }
    }
}
