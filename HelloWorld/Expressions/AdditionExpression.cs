namespace HelloWorld
{

    public class AdditionExpression : BinaryExpression<int>
    {
        public AdditionExpression(Expression<int> left, Expression<int> right) : base(left, right)
        {
        }

        public override int Value => _left.Value + _right.Value;
    }

    public class Multiply : BinaryExpression<int>
    {
        public Multiply(Expression<int> left, Expression<int> right) : base(left, right)
        {
        }

        public override int Value => _left.Value*_right.Value;
    }

    public class NegativeOf : UnaryExpression<int>
    {
        public NegativeOf(int value) : base(value)
        {
        }

        public override int Value => -base.Value;

    }

}