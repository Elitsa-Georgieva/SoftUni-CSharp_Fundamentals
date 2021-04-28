using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] firstArr = new int[size];
            int[] secondArr = new int[size];

            for (int i = 0; i < size; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 != 0)
                {
                    firstArr[i] = secondNum;
                    secondArr[i] = firstNum;
                }
                else
                {
                    firstArr[i] = firstNum;
                    secondArr[i] = secondNum;
                }
            }

            Console.WriteLine(String.Join(" ", firstArr));
            Console.WriteLine(String.Join(" ", secondArr));
        }
    }
}

