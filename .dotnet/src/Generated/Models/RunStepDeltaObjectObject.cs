// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The RunStepDeltaObject_object. </summary>
    internal readonly partial struct RunStepDeltaObjectObject : IEquatable<RunStepDeltaObjectObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStepDeltaObjectObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStepDeltaObjectObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadRunStepDeltaValue = "thread.run.step.delta";

        /// <summary> thread.run.step.delta. </summary>
        public static RunStepDeltaObjectObject ThreadRunStepDelta { get; } = new RunStepDeltaObjectObject(ThreadRunStepDeltaValue);
        /// <summary> Determines if two <see cref="RunStepDeltaObjectObject"/> values are the same. </summary>
        public static bool operator ==(RunStepDeltaObjectObject left, RunStepDeltaObjectObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStepDeltaObjectObject"/> values are not the same. </summary>
        public static bool operator !=(RunStepDeltaObjectObject left, RunStepDeltaObjectObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunStepDeltaObjectObject"/>. </summary>
        public static implicit operator RunStepDeltaObjectObject(string value) => new RunStepDeltaObjectObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepDeltaObjectObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStepDeltaObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
