﻿#nullable enable

using System;

namespace Azure.AI.OpenAI;

[AttributeUsage(AttributeTargets.Class)]
internal class CodeGenClientAttribute : CodeGenTypeAttribute
{
    public Type? ParentClient { get; set; }

    public CodeGenClientAttribute(string originalName) : base(originalName)
    {
    }
}