namespace HelloWorld
{
    public class UnaryExpression<T> : Expression<T>
    {
        protected T _value;
        public UnaryExpression(T value)
        {
            _value = value;
        }

        public override T Value { get => _value; }
    }

}