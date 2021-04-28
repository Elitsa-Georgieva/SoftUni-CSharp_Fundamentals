using System;

namespace _03.Passed_or_Failed
{
    class Program
    {
        static void Main(string[] args)
        {
            double Grade = double.Parse(Console.ReadLine());

            if (Grade >= 3.00)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
