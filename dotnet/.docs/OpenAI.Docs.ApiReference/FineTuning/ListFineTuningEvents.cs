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
    public void ListFineTuningEvents()
    {
        #region logic
        FineTuningClient client = new(
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );

        FineTuningJob job = client.GetJob("ftjob-abc123");
        foreach (FineTuningEvent jobEvent in job.GetEvents(new GetEventsOptions()))
        {
            Console.WriteLine($"Event {jobEvent.Id} ({jobEvent.Kind}): {jobEvent.Message}");
        }

        #endregion

    }
}
