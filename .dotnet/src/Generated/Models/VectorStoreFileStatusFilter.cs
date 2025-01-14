// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.VectorStores
{
    /// <summary> The ListVectorStoreFilesFilter. </summary>
    public readonly partial struct VectorStoreFileStatusFilter : IEquatable<VectorStoreFileStatusFilter>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="VectorStoreFileStatusFilter"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public VectorStoreFileStatusFilter(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "in_progress";
        private const string CompletedValue = "completed";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";

        /// <summary> in_progress. </summary>
        public static VectorStoreFileStatusFilter InProgress { get; } = new VectorStoreFileStatusFilter(InProgressValue);
        /// <summary> completed. </summary>
        public static VectorStoreFileStatusFilter Completed { get; } = new VectorStoreFileStatusFilter(CompletedValue);
        /// <summary> failed. </summary>
        public static VectorStoreFileStatusFilter Failed { get; } = new VectorStoreFileStatusFilter(FailedValue);
        /// <summary> cancelled. </summary>
        public static VectorStoreFileStatusFilter Cancelled { get; } = new VectorStoreFileStatusFilter(CancelledValue);
        /// <summary> Determines if two <see cref="VectorStoreFileStatusFilter"/> values are the same. </summary>
        public static bool operator ==(VectorStoreFileStatusFilter left, VectorStoreFileStatusFilter right) => left.Equals(right);
        /// <summary> Determines if two <see cref="VectorStoreFileStatusFilter"/> values are not the same. </summary>
        public static bool operator !=(VectorStoreFileStatusFilter left, VectorStoreFileStatusFilter right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="VectorStoreFileStatusFilter"/>. </summary>
        public static implicit operator VectorStoreFileStatusFilter(string value) => new VectorStoreFileStatusFilter(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is VectorStoreFileStatusFilter other && Equals(other);
        /// <inheritdoc />
        public bool Equals(VectorStoreFileStatusFilter other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
