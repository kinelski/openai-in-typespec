// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The MessageContentImageUrlObject_type. </summary>
    internal readonly partial struct MessageContentImageUrlObjectType : IEquatable<MessageContentImageUrlObjectType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageContentImageUrlObjectType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageContentImageUrlObjectType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ImageUrlValue = "image_url";

        /// <summary> image_url. </summary>
        public static MessageContentImageUrlObjectType ImageUrl { get; } = new MessageContentImageUrlObjectType(ImageUrlValue);
        /// <summary> Determines if two <see cref="MessageContentImageUrlObjectType"/> values are the same. </summary>
        public static bool operator ==(MessageContentImageUrlObjectType left, MessageContentImageUrlObjectType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageContentImageUrlObjectType"/> values are not the same. </summary>
        public static bool operator !=(MessageContentImageUrlObjectType left, MessageContentImageUrlObjectType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageContentImageUrlObjectType"/>. </summary>
        public static implicit operator MessageContentImageUrlObjectType(string value) => new MessageContentImageUrlObjectType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageContentImageUrlObjectType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageContentImageUrlObjectType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
