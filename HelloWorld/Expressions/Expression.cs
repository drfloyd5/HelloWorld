using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public abstract class Expression<T>
    {
        public abstract T Value { get; }

        public override bool Equals(object obj) => obj is Expression<T> expression &&
                   EqualityComparer<T>.Default.Equals(Value, expression.Value);

        public override int GetHashCode() => HashCode.Combine(Value);
        public override string ToString() => Value.ToString();

    }

}