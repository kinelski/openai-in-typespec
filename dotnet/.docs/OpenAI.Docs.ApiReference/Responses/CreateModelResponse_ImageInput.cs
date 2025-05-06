#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;
using System.Collections.Generic;

using OpenAI.Responses;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class ResponseDocs
{
    [Test]
    public void CreateModelResponse_ImageInput()
    {
        #region logic

        OpenAIResponseClient client = new(
            model: "gpt-4o",
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        List<ResponseItem> inputItems =
        [
            ResponseItem.CreateUserMessageItem(
                [
                    ResponseContentPart.CreateInputTextPart("What is in this image?"),
                    ResponseContentPart.CreateInputImagePart(new Uri("https://upload.wikimedia.org/wikipedia/commons/thumb/d/dd/Gfp-wisconsin-madison-the-nature-boardwalk.jpg/2560px-Gfp-wisconsin-madison-the-nature-boardwalk.jpg"))
                ]
            )
        ];

        OpenAIResponse response = client.CreateResponse(inputItems);

        Console.WriteLine(response.GetOutputText());

        #endregion

        Assert.That(response, Is.Not.Null);
        Assert.That(response.OutputItems, Has.Count.GreaterThan(0));
        Assert.That(response.GetOutputText(), Is.Not.Null.Or.Empty);
    }
}
