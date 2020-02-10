namespace HelloWorld
{


    public class AdditionExpression : BinaryExpression<int>
    {
        public AdditionExpression(Expression<int> left, Expression<int> right) : base(left, right)
        {
        }

        public override int Value => _left.Value + _right.Value;
    }

}