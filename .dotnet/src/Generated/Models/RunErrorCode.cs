// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Assistants
{
    /// <summary> Enum for code in RunError. </summary>
    public readonly partial struct RunErrorCode : IEquatable<RunErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerErrorValue = "server_error";
        private const string RateLimitExceededValue = "rate_limit_exceeded";
        private const string InvalidPromptValue = "invalid_prompt";

        /// <summary> server_error. </summary>
        public static RunErrorCode ServerError { get; } = new RunErrorCode(ServerErrorValue);
        /// <summary> rate_limit_exceeded. </summary>
        public static RunErrorCode RateLimitExceeded { get; } = new RunErrorCode(RateLimitExceededValue);
        /// <summary> invalid_prompt. </summary>
        public static RunErrorCode InvalidPrompt { get; } = new RunErrorCode(InvalidPromptValue);
        /// <summary> Determines if two <see cref="RunErrorCode"/> values are the same. </summary>
        public static bool operator ==(RunErrorCode left, RunErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunErrorCode"/> values are not the same. </summary>
        public static bool operator !=(RunErrorCode left, RunErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunErrorCode"/>. </summary>
        public static implicit operator RunErrorCode(string value) => new RunErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
