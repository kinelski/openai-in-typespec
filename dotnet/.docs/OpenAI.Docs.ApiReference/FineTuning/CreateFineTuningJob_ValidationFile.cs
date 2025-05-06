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
    public void CreateFineTuningJob_ValidationFile()
    {
        #region logic

        FineTuningClient client = new(
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        FineTuningJob result = client.FineTune(
            baseModel: "gpt-4o-mini",
            trainingFileId: "file-abc123",
            waitUntilCompleted: true);

        #endregion

        Console.WriteLine($"Validation file: {result.ValidationFileId}");
    }
}
