using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                // числото което ни е на и-тия индекс, представлява числото, което ще търсим дали е топЧисло!!
                bool isTopNumber = true;

                for (int j = i + 1; j < numbers.Length; j++)
                    //обхождаме числата, които са вдясно от текущото число - ще се върти до numbers.Length
                {
                    int rightNum = numbers[j];

                    if(rightNum >= currentNum)
                    {
                        isTopNumber = false;
                        break;
                    }
                }
                if (isTopNumber)
                {
                    Console.Write($"{currentNum} ");
                }
            }
            Console.WriteLine();
        }
    }
}
