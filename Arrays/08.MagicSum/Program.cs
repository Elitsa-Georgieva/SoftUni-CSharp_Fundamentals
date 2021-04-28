using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int targetSum = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
                // 1
                // 7
                // 6
                // 2
                // 19
                // 23
            {
                int currentNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNum = numbers[j];
                    if(currentNum + rightNum == targetSum)
                    {
                        Console.WriteLine($"{currentNum} {rightNum}");
                        break;
                    }
                }
            }
        }
    }
}
