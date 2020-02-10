namespace HelloWorld
{
    public class Divide : BinaryExpression<decimal>
    {

        

        public Divide(Expression<decimal> numerator, Expression<decimal> deminitator) :base(numerator,deminitator) {

        }
        public override decimal Value => _left.Value / _right.Value;

    }

}