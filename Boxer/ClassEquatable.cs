using System;

namespace Boxer
{
    public class ClassEquatable : IEquatable<ClassEquatable>
    {
        public int Value { get; set; }

        public bool Equals(ClassEquatable other)
        {
            return Value == other.Value;
        }
    }
}