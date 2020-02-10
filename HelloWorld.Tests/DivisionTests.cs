using NUnit.Framework;
using HelloWorld;
using System;

namespace HelloWorld.Tests
{
    [TestFixture]
    public class Division_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Two_Zero()
        {
            try {
               var x = new Divide(new UnaryExpression<decimal>(2), new UnaryExpression<decimal>(0));
            } catch(Exception) {

            }
            Assert.Fail("Should fail when dividing by zero.");
        }

        [TestCase(2, 2, 4)]
        [TestCase(2, 0, 2)]
        [TestCase(0, -2, -2)]
        public void Addition_TestCases(int a, int b, int expectedValue)
        {

            var additionExpression = new AdditionExpression(new UnaryExpression<int>(a), new UnaryExpression<int>(b));

            var value = additionExpression;


            Assert.AreEqual(new UnaryExpression<int>(expectedValue), value);

        }


        [Test]
        public void Two_Plus_Two_Times_Negative_Four_Equals_negative_Eight()
        {
            var two = new UnaryExpression<int>(2);
            var additionExpression = new AdditionExpression(two, two);
            var multiply = new Multiply(additionExpression, new NegativeOf(two.Value));
            var value = multiply.Value;

            Assert.AreEqual(-8, value, "Two + Two = 4");

        }


    }
}