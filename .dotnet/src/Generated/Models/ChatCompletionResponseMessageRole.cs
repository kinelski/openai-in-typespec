// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The ChatCompletionResponseMessage_role. </summary>
    internal readonly partial struct ChatCompletionResponseMessageRole : IEquatable<ChatCompletionResponseMessageRole>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionResponseMessageRole"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChatCompletionResponseMessageRole(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AssistantValue = "assistant";

        /// <summary> assistant. </summary>
        public static ChatCompletionResponseMessageRole Assistant { get; } = new ChatCompletionResponseMessageRole(AssistantValue);
        /// <summary> Determines if two <see cref="ChatCompletionResponseMessageRole"/> values are the same. </summary>
        public static bool operator ==(ChatCompletionResponseMessageRole left, ChatCompletionResponseMessageRole right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChatCompletionResponseMessageRole"/> values are not the same. </summary>
        public static bool operator !=(ChatCompletionResponseMessageRole left, ChatCompletionResponseMessageRole right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChatCompletionResponseMessageRole"/>. </summary>
        public static implicit operator ChatCompletionResponseMessageRole(string value) => new ChatCompletionResponseMessageRole(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatCompletionResponseMessageRole other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChatCompletionResponseMessageRole other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
