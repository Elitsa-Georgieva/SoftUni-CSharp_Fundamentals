using System;
using System.Linq;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read two integer numbers. Calculate factorial of each number.
            //Divide the first result by the second and print the division
            //formatted to the second decimal point.

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());

            double factorialOne = GetFactorial(one);
            double factorialTwo = GetFactorial(two);

            double result = (double)factorialOne / factorialTwo;

            Console.WriteLine($"{result:f2}");
        }

        private static double GetFactorial(int number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
