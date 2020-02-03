namespace HelloWorld
{
    public abstract class BinaryExpression<T> : Expression<T>
    {
        protected Expression<T> _left;
        protected Expression<T> _right;
        public BinaryExpression(Expression<T> left, Expression<T> right)
        {
            _left = left;
            _right = right;
        }

    }

}