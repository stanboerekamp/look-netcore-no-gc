using System;

namespace Boxer
{
    public class ClassWithReferenceSpecializedEquals
    {
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            return ReferenceEquals(this, obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
