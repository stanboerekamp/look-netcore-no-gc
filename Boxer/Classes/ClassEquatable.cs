using System;

namespace Boxer.Classes
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