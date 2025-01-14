﻿using System;

namespace Azure.AI.OpenAI;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Struct, AllowMultiple = true)]
internal class CodeGenSuppressAttribute : Attribute
{
    public string Member { get; }
    public Type[] Parameters { get; }

    public CodeGenSuppressAttribute(string member, params Type[] parameters)
    {
        Member = member;
        Parameters = parameters;
    }
}