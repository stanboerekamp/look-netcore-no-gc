using System;

namespace Boxer
{
    public struct StructEquatable : IEquatable<StructEquatable>
    {
        public int Value { get; set; }

        public bool Equals(StructEquatable other)
        {
            return Value == other.Value;
        }
    }
}
