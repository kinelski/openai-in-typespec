// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI
{
    /// <summary> The ListOrder. </summary>
    public readonly partial struct ListOrder : IEquatable<ListOrder>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListOrder"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListOrder(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OldestFirstValue = "asc";
        private const string NewestFirstValue = "desc";
        /// <summary> Determines if two <see cref="ListOrder"/> values are the same. </summary>
        public static bool operator ==(ListOrder left, ListOrder right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListOrder"/> values are not the same. </summary>
        public static bool operator !=(ListOrder left, ListOrder right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ListOrder"/>. </summary>
        public static implicit operator ListOrder(string value) => new ListOrder(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListOrder other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListOrder other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
