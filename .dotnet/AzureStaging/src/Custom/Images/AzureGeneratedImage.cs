﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.AI.OpenAI.Internal;
using OpenAI.Images;
using System.Diagnostics.CodeAnalysis;

namespace Azure.AI.OpenAI.Images;

public static class AzureGeneratedImageExtensions
{
    [Experimental("OPENAI002")]
    public static ImageContentFilterResultForPrompt GetContentFilterResultForPrompt(this GeneratedImage image)
    {
        return AdditionalPropertyHelpers.GetAdditionalProperty<ImageContentFilterResultForPrompt>(
            image._serializedAdditionalRawData,
            "prompt_filter_results");
    }

    [Experimental("OPENAI002")]
    public static ImageContentFilterResultForResponse GetContentFilterResultForResponse(this GeneratedImage image)
    {
        return AdditionalPropertyHelpers.GetAdditionalProperty<ImageContentFilterResultForResponse>(
            image._serializedAdditionalRawData,
            "content_filter_results");
    }
}