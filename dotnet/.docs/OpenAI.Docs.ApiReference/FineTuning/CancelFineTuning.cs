using NUnit.Framework;

#region usings
using System;
using System.ClientModel.Primitives;

using OpenAI.FineTuning;
#endregion

namespace OpenAI.Docs.ApiReference;

public partial class FineTuningDocs
{
    //[Test]
    public void CancelFineTuning()
    {
        #region logic
        FineTuningClient client = new(
            apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
        );
        FineTuningJob job = client.GetJob("ftjob-abc123");
        job.CancelAndUpdate();
        #endregion
    }
}
