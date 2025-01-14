// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Images
{
    /// <summary> Enum for size in ImageGenerationOptions. </summary>
    public readonly partial struct GeneratedImageSize : IEquatable<GeneratedImageSize>
    {
        private const string W256xH256Value = "256x256";
        private const string W512xH512Value = "512x512";
        private const string W1024xH1024Value = "1024x1024";
        private const string W1024xH1792Value = "1792x1024";
        private const string W1792xH1024Value = "1024x1792";
        /// <summary> Determines if two <see cref="GeneratedImageSize"/> values are the same. </summary>
        public static bool operator ==(GeneratedImageSize left, GeneratedImageSize right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GeneratedImageSize"/> values are not the same. </summary>
        public static bool operator !=(GeneratedImageSize left, GeneratedImageSize right) => !left.Equals(right);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GeneratedImageSize other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GeneratedImageSize other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
