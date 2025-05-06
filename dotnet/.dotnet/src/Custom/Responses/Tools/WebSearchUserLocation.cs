namespace OpenAI.Responses;

[CodeGenType("WebSearchToolUserLocation")]
public partial class WebSearchUserLocation
{
    public static WebSearchUserLocation CreateApproximateLocation(string country = null, string region = null, string city = null, string timezone = null)
    {
        return new InternalWebSearchToolUserLocationApproximate(
            InternalWebSearchUserLocationKind.Approximate,
            additionalBinaryDataProperties: null,
            country,
            region,
            city,
            timezone);
    }
}