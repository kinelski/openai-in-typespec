// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning
{
    /// <summary> The CreateFineTuningJobRequestIntegration_type. </summary>
    internal readonly partial struct InternalCreateFineTuningJobRequestIntegrationType : IEquatable<InternalCreateFineTuningJobRequestIntegrationType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalCreateFineTuningJobRequestIntegrationType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalCreateFineTuningJobRequestIntegrationType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WandbValue = "wandb";

        /// <summary> wandb. </summary>
        public static InternalCreateFineTuningJobRequestIntegrationType Wandb { get; } = new InternalCreateFineTuningJobRequestIntegrationType(WandbValue);
        /// <summary> Determines if two <see cref="InternalCreateFineTuningJobRequestIntegrationType"/> values are the same. </summary>
        public static bool operator ==(InternalCreateFineTuningJobRequestIntegrationType left, InternalCreateFineTuningJobRequestIntegrationType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalCreateFineTuningJobRequestIntegrationType"/> values are not the same. </summary>
        public static bool operator !=(InternalCreateFineTuningJobRequestIntegrationType left, InternalCreateFineTuningJobRequestIntegrationType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalCreateFineTuningJobRequestIntegrationType"/>. </summary>
        public static implicit operator InternalCreateFineTuningJobRequestIntegrationType(string value) => new InternalCreateFineTuningJobRequestIntegrationType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateFineTuningJobRequestIntegrationType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalCreateFineTuningJobRequestIntegrationType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
