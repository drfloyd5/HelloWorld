namespace HelloWorld
{
    public class Multiply : BinaryExpression<int>
    {
        public Multiply(Expression<int> left, Expression<int> right) : base(left, right)
        {
        }

        public override int Value => _left.Value*_right.Value;
    }

}