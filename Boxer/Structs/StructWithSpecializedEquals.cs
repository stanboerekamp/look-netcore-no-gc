using System;

namespace Boxer.Structs
{
    public struct StructWithSpecializedEquals
    {
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            return !(obj is StructWithSpecializedEquals) ? false : ((StructWithSpecializedEquals)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
