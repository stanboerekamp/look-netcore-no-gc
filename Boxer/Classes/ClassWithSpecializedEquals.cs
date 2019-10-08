using System;

namespace Boxer.Classes
{
    public class ClassWithSpecializedEquals
    {
        public int Value { get; set; }

        public override bool Equals(object obj)
        {
            return !(obj is ClassWithSpecializedEquals other) ? false : other.Value == Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}

