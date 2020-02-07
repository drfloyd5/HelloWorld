using NUnit.Framework;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class ExpressionEquality_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Two_Equals_Two()
        {
            var a = new UnaryExpression<int>(2);
            var b = new UnaryExpression<int>(2);
            
            Assert.AreEqual(a, b);

        }


    }
}