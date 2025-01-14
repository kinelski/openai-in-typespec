// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    /// <summary> Enum for reason in RunIncompleteDetails. </summary>
    public readonly partial struct RunIncompleteReason : IEquatable<RunIncompleteReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunIncompleteReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunIncompleteReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string MaxCompletionTokensValue = "max_completion_tokens";
        private const string MaxPromptTokensValue = "max_prompt_tokens";

        /// <summary> max_completion_tokens. </summary>
        public static RunIncompleteReason MaxCompletionTokens { get; } = new RunIncompleteReason(MaxCompletionTokensValue);
        /// <summary> max_prompt_tokens. </summary>
        public static RunIncompleteReason MaxPromptTokens { get; } = new RunIncompleteReason(MaxPromptTokensValue);
        /// <summary> Determines if two <see cref="RunIncompleteReason"/> values are the same. </summary>
        public static bool operator ==(RunIncompleteReason left, RunIncompleteReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunIncompleteReason"/> values are not the same. </summary>
        public static bool operator !=(RunIncompleteReason left, RunIncompleteReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunIncompleteReason"/>. </summary>
        public static implicit operator RunIncompleteReason(string value) => new RunIncompleteReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunIncompleteReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunIncompleteReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
