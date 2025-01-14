﻿using System;
using System.ClientModel;
using NUnit.Framework;
using OpenAI.Embeddings;
using OpenAI.Tests.Utility;
using System.Collections.Generic;
using System.Threading.Tasks;
using static OpenAI.Tests.TestHelpers;

namespace OpenAI.Tests.Embeddings;

[TestFixture(true)]
[TestFixture(false)]
public partial class EmbeddingTests : SyncAsyncTestBase
{
    public EmbeddingTests(bool isAsync)
        : base(isAsync)
    {
    }

    [Test]
    public async Task GenerateSingleEmbedding()
    {
        EmbeddingClient client = new("text-embedding-3-small");

        string input = "Hello, world!";

        Embedding embedding = IsAsync
            ? await client.GenerateEmbeddingAsync(input)
            : client.GenerateEmbedding(input);
        Assert.That(embedding, Is.Not.Null);
        Assert.That(embedding.Index, Is.EqualTo(0));
        Assert.That(embedding.Vector, Is.Not.Null);
        Assert.That(embedding.Vector.Span.Length, Is.EqualTo(1536));
        
        float[] array = embedding.Vector.ToArray();
        Assert.That(array.Length, Is.EqualTo(1536));
    }

    [Test]
    public async Task GenerateMultipleEmbeddings()
    {
        EmbeddingClient client = new("text-embedding-3-small");

        const int Dimensions = 456;

        List<string> prompts =
        [
            "Hello, world!",
            "This is a test.",
            "Goodbye!"
        ];

        EmbeddingGenerationOptions options = new()
        {
            Dimensions = Dimensions,
        };

        EmbeddingCollection embeddings = IsAsync
            ? await client.GenerateEmbeddingsAsync(prompts, options)
            : client.GenerateEmbeddings(prompts, options);
        Assert.That(embeddings, Is.Not.Null);
        Assert.That(embeddings.Count, Is.EqualTo(3));
        Assert.That(embeddings.Model, Is.EqualTo("text-embedding-3-small"));
        Assert.That(embeddings.Usage.InputTokens, Is.GreaterThan(0));
        Assert.That(embeddings.Usage.TotalTokens, Is.GreaterThan(0));

        for (int i = 0; i < embeddings.Count; i++)
        {
            Assert.That(embeddings[i].Index, Is.EqualTo(i));
            Assert.That(embeddings[i].Vector, Is.Not.Null);
            Assert.That(embeddings[i].Vector.Span.Length, Is.EqualTo(Dimensions));

            float[] array = embeddings[i].Vector.ToArray();
            Assert.That(array.Length, Is.EqualTo(Dimensions));
        }
    }

    [Test]
    public async Task BadOptions()
    {
        EmbeddingClient client = GetTestClient();

        EmbeddingGenerationOptions options = new()
        {
            Dimensions = -42,
        };

        Exception caughtException = null;

        try
        {
            _ = IsAsync
                ? await client.GenerateEmbeddingAsync("foo", options)
                : client.GenerateEmbedding("foo", options);
        }
        catch (Exception ex)
        {
            caughtException = ex;
        }

        Assert.That(caughtException, Is.InstanceOf<ClientResultException>());
        Assert.That(caughtException.Message, Contains.Substring("dimensions"));
    }

    [Test]
    public void SerializeEmbeddingCollection()
    {
        // TODO: Add this test.
    }

    private static EmbeddingClient GetTestClient() => GetTestClient<EmbeddingClient>(TestScenario.Embeddings);
}
