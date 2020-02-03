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
            
            Assert.AreEqual(4,4,"Two + Two = 4");
            
        }
    }
}