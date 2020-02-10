// DrFloyd5 Forked to Develop Division.
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var two = new UnaryExpression<int>(2);
            var four = new AdditionExpression(two,two);

            Console.WriteLine($"Two + two = {four.Value}");

            var eight = new Multiply(four, new NegativeOf(2));
            Console.WriteLine($"Four * -two = {eight.Value}");
        }
    }

}