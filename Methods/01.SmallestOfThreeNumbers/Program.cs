using System;
using System.Runtime.ExceptionServices;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = GetTheSmallest(first, second, third);
            Console.WriteLine(min);
        }

        //Write a method to print the smallest of three integer numbers.
        //Use appropriate name for the method.

        static int GetTheSmallest(int first, int second, int third)
        {
            int min = Math.Min
                (Math.Min(first, second), 
                third);

            return min;
        }
    }
}
