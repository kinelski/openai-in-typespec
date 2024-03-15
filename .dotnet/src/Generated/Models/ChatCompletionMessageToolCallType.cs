// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The ChatCompletionMessageToolCall_type. </summary>
    internal readonly partial struct ChatCompletionMessageToolCallType : IEquatable<ChatCompletionMessageToolCallType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionMessageToolCallType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ChatCompletionMessageToolCallType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string FunctionValue = "function";

        /// <summary> function. </summary>
        public static ChatCompletionMessageToolCallType Function { get; } = new ChatCompletionMessageToolCallType(FunctionValue);
        /// <summary> Determines if two <see cref="ChatCompletionMessageToolCallType"/> values are the same. </summary>
        public static bool operator ==(ChatCompletionMessageToolCallType left, ChatCompletionMessageToolCallType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ChatCompletionMessageToolCallType"/> values are not the same. </summary>
        public static bool operator !=(ChatCompletionMessageToolCallType left, ChatCompletionMessageToolCallType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ChatCompletionMessageToolCallType"/>. </summary>
        public static implicit operator ChatCompletionMessageToolCallType(string value) => new ChatCompletionMessageToolCallType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ChatCompletionMessageToolCallType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ChatCompletionMessageToolCallType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}