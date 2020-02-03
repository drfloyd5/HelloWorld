using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class Expressions_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Two_Plus_Two_Equals_Four()
        {
            var two = new UnaryExpression<int>(2);
            var additionExpression = new AdditionExpression(two,two);
            var value = additionExpression.Value;
            
            Assert.AreEqual(4,value,"Two + Two = 4");

        }  [Test]
        public void Two_Plus_Two_Times_Negative_Four_Equals_negative_Eight()
        {
            var two = new UnaryExpression<int>(2);
            var additionExpression = new AdditionExpression(two,two);
            var multiply = new Multiply(additionExpression, new NegativeOf(two.Value));
            var value = additionExpression.Value;
            
            Assert.AreEqual(-8,value,"Two + Two = 4");

        }

       
    }
}