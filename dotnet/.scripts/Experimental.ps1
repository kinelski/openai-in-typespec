# An API listing is a C# file that contains a collection of namespaces and the types within them, such as:
# ```csharp
# namespace NameSpace1 {
#     public class Class1 { }
#     public class Class2 { }
# }
# namespace NameSpace2 {
#     public class Class3 { }
#     [Experimental("OPENAI001")]
#     public class Class4 { }
#     public enum Enum1 { }
# }
# ```
# Some of these types have the `Experimental` attribute applied to them.
# The following function receives the path to an API listing and lists the names of all the types that have
# the `Experimental` attribute applied to them, along with the reason for their experimental status.
function List-ExperimentalTypes {
    param (
        [string]$apiListingPath
    )

    # Read the API listing file.
    $apiListing = Get-Content $apiListingPath -Raw

    # Use a regular expression to find all the types with the Experimental attribute.
    $regex = '\[Experimental\("([^"]+)"\)\]\s*(public|internal|protected|private)?\s?(readonly )?(partial )?(class|struct|enum|interface)\s+(\w+)'
    $matches = [regex]::Matches($apiListing, $regex)

    # Create an array to hold the results.
    $results = @()

    # Iterate over the matches and extract the relevant information.
    foreach ($match in $matches) {
        $reason = $match.Groups[1].Value
        $typeName = $match.Groups[6].Value
        $results += [PSCustomObject]@{
            TypeName = $typeName
            Reason   = $reason
        }
    }

    # Return the results.
    return $results
}

List-ExperimentalTypes -apiListingPath ".\.dotnet\api\OpenAI.net8.0.cs" | Format-Table -AutoSize