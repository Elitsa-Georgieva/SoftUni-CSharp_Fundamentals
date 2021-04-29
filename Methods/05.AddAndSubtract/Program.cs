using System;
using System.Diagnostics.CodeAnalysis;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive 3 integers.
            //Write a method Sum to get the sum of the first two integers and
            //Subtract method that subtracts the third integer from the result from the Sum method. 

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = GetSum(first, second);
            int difference = GetSubstract(sum, third);

            Console.WriteLine(difference);

        }

        private static int GetSubstract(int first, int second)
        {
            return first - second;
        }

        private static int GetSum(int first, int second)
        {
            return first + second;
        }
    }
}
