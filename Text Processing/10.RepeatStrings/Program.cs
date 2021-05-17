using System;
using System.ComponentModel;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string result = String.Empty;

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }
            Console.WriteLine(result);

        }
    }
}
