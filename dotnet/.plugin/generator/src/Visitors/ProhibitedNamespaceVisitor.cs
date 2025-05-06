using Microsoft.TypeSpec.Generator.ClientModel;
using Microsoft.TypeSpec.Generator.Primitives;
using Microsoft.TypeSpec.Generator.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenAILibraryPlugin.Visitors;

/// <summary>
/// A visitor that throws an exception if a generated namespace is prohibited. This happens when a newly introduced
/// type isn't emplaced into its appropriate namespace. Custom code definitions, including stubs that only emplace in
/// namespaces, are exempt and will cause the generated code to be accepted.
/// </summary>
public class ProhibitedNamespaceVisitor : ScmLibraryVisitor
{
    private static List<TypeProvider> ViolatingTypes = [];

    public ProhibitedNamespaceVisitor()
    {
        AppDomain.CurrentDomain.ProcessExit += (s, e) =>
        {
            if (ViolatingTypes.Count > 0)
            {
                StringBuilder messageBuilder = new();
                messageBuilder.AppendLine();
                messageBuilder.AppendLine(
                    "[ERROR] The following types were emitted to a restricted namespace."
                    + " Please forward-declare in an appropriate namespace to resolve.");
                messageBuilder.AppendLine();
                foreach (TypeProvider violatingType in ViolatingTypes)
                {
                    messageBuilder.Append($"[CodeGenType(\"{violatingType.Name}\")] internal ");
                    messageBuilder.Append(violatingType.Type.IsValueType
                        ? "readonly partial struct "
                        : "partial class ");
                    messageBuilder.AppendLine($"Internal{violatingType.Name} {{}}");
                }
                messageBuilder.AppendLine();
                throw new ArgumentException(messageBuilder.ToString());
            }
        };
    }

    protected override TypeProvider VisitType(TypeProvider type)
    {
        bool isPublicType = type.DeclarationModifiers.HasFlag(TypeSignatureModifiers.Public);
        bool isUnknownPrefixedType = type.Type.Name.StartsWith("Unknown");

        if ((isPublicType || isUnknownPrefixedType)
            && (type.Type.Namespace == "OpenAI" || type.Type.Namespace == "OpenAI.Models")
            && string.IsNullOrEmpty(type.CustomCodeView?.Type.Namespace)
            && !ViolatingTypes.Any(trackedType => type.Name == trackedType.Name))
        {
            ViolatingTypes.Add(type);
        }
        return type;
    }
}