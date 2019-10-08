using System;

namespace Boxer.Structs
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
