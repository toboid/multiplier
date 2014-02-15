using System;

namespace Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var multiplier = new Multiplier();

            Console.WriteLine("Enter first integer");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second integer");
            var second = int.Parse(Console.ReadLine());

            var answer = multiplier.Multiply(first, second);
            Console.WriteLine("{0} * {1} = {2}", first, second, answer);
        }
    }
}
