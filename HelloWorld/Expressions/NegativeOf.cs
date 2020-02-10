namespace HelloWorld
{
    public class NegativeOf : UnaryExpression<int>
    {
        public NegativeOf(int value) : base(value)
        {
        }

        public override int Value => -base.Value;

    }

}