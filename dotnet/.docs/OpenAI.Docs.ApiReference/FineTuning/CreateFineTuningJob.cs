using NUnit.Framework;
using System.Text.Json;

#region usings
using System;
using System.ClientModel;

using OpenAI.FineTuning;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class FineTuningDocs
{
    //[Test]
    public void CreateFineTuningJob()
    {
        #region logic

        FineTuningClient client = new(
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        var result = client.FineTune(
            baseModel: "gpt-4o",
            trainingFileId: "file_abc123",
            waitUntilCompleted: false);

        #endregion

        BinaryData output = result.GetRawResponse().Content;
        using JsonDocument outputAsJson = JsonDocument.Parse(output);
        Console.WriteLine(outputAsJson.RootElement.ToString());
    }
}
