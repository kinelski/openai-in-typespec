namespace OpenAI.Responses;

[CodeGenType("AnnotationType")]
public enum ResponseMessageAnnotationKind
{
    FileCitation,

    [CodeGenMember("UrlCitation")]
    UriCitation,

    FilePath
}