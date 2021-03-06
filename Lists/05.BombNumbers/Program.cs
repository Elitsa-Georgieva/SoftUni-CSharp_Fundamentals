using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombData = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombData[0];
            int bombPower = bombData[1];

            while (true)
            {
                int idx = numbers.IndexOf(bombNumber);

                if (idx == -1)
                {
                    break;
                }

                int startIdx = idx - bombPower;

                if (startIdx < 0)
                {
                    startIdx = 0;
                }

                //колко на брой елементи можем да изтрием тригърквайки бомбата?

                int count = 2 * bombPower + 1;

                //не валиден каунтър 
                if (count  >= numbers.Count - startIdx)
                {
                    count = numbers.Count - startIdx;
                }

                numbers.RemoveRange(startIdx, count);
               
            }

            int sum = 0;

            foreach (var num in numbers)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
