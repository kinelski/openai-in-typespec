﻿using OpenAI.Assistants;
using OpenAI.Audio;
using OpenAI.Batch;
using OpenAI.Chat;
using OpenAI.Embeddings;
using OpenAI.Files;
using OpenAI.Images;
using OpenAI.VectorStores;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OpenAI.Tests;

internal static class TestHelpers
{
    public enum TestScenario
    {
        Assistants,
        Batch,
        Chat,
        Embeddings,
        Files,
        FineTuning,
        Images,
        LegacyCompletions,
        Models,
        Moderations,
        TextToSpeech,
        TopLevel,
        Transcription,
        VectorStores,
        VisionChat,
    }

    public static OpenAIClient GetTestTopLevelClient() => GetTestClient<OpenAIClient>(TestScenario.TopLevel);

    public static T GetTestClient<T>(TestScenario scenario, string overrideModel = null)
    {
        OpenAIClientOptions options = new();
        options.AddPolicy(GetDumpPolicy(), PipelinePosition.PerTry);
        object clientObject = scenario switch
        {
#pragma warning disable OPENAI001
            TestScenario.Assistants => new AssistantClient(options),
            TestScenario.VectorStores => new VectorStoreClient(options),
#pragma warning restore OPENAI001
            TestScenario.Embeddings => new EmbeddingClient(overrideModel ?? "text-embedding-3-small", options),
            TestScenario.Batch => new BatchClient(options),
            TestScenario.Chat => new ChatClient(overrideModel ?? "gpt-3.5-turbo", options),
            TestScenario.Files => new FileClient(options),
            TestScenario.Images => new ImageClient(overrideModel ?? "dall-e-3", options),
            TestScenario.Transcription => new AudioClient(overrideModel ?? "whisper-1", options),
            TestScenario.VisionChat => new ChatClient(overrideModel ?? "gpt-4-vision-preview", options),
            TestScenario.TopLevel => new OpenAIClient(options),
            _ => throw new NotImplementedException(),
        };
        return (T)clientObject;
    }

    private static PipelinePolicy GetDumpPolicy()
    {
        return new TestPipelinePolicy((message) =>
        {
            Console.WriteLine($"--- New request ---");
            IEnumerable<string> headerPairs = message?.Request?.Headers?.Select(header => $"{header.Key}={(header.Key.ToLower().Contains("auth") ? "***" : header.Value)}");
            string headers = string.Join(',', headerPairs);
            Console.WriteLine($"Headers: {headers}");
            Console.WriteLine($"{message?.Request?.Method} URI: {message?.Request?.Uri}");
            if (message.Request?.Content != null)
            {
                using MemoryStream stream = new();
                message.Request.Content.WriteTo(stream, default);
                stream.Position = 0;
                using StreamReader reader = new(stream);
                Console.WriteLine(reader.ReadToEnd());
            }
            if (message.Response != null)
            {
                Console.WriteLine("--- Begin response content ---");
                Console.WriteLine(message.Response.Content?.ToString());
                Console.WriteLine("--- End of response content ---");
            }
        });
    }
}