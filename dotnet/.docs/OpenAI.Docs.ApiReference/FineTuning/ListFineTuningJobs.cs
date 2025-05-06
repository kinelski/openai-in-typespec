using NUnit.Framework;
using System.Text.Json;

#region usings
using System;
using System.ClientModel.Primitives;

using OpenAI.FineTuning;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class FineTuningDocs
{
    //[Test]
    public void ListFineTuningJobs()
    {
        #region logic

        FineTuningClient client = new(
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        foreach (FineTuningJob job in client.GetJobs())
        {
            Console.WriteLine($"Job {job.JobId} ({job.Status}): {job.BaseModel} with {job.TrainingFileId}");
        }

        #endregion
    }
}
