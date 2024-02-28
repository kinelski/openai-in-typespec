// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The ListRunStepsResponse_object. </summary>
    internal readonly partial struct ListRunStepsResponseObject : IEquatable<ListRunStepsResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListRunStepsResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListRunStepsResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static ListRunStepsResponseObject List { get; } = new ListRunStepsResponseObject(ListValue);
        /// <summary> Determines if two <see cref="ListRunStepsResponseObject"/> values are the same. </summary>
        public static bool operator ==(ListRunStepsResponseObject left, ListRunStepsResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListRunStepsResponseObject"/> values are not the same. </summary>
        public static bool operator !=(ListRunStepsResponseObject left, ListRunStepsResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ListRunStepsResponseObject"/>. </summary>
        public static implicit operator ListRunStepsResponseObject(string value) => new ListRunStepsResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListRunStepsResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListRunStepsResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
