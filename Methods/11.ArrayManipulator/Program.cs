using System;
using System.Linq;
using System.Security.Authentication;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "exchange")
                {
                    int idx = int.Parse(parts[1]);
                    Exchange(numbers, idx);

                }
            }
        }

        private static void Exchange(int[] numbers, int idx)
        {
            //- If the index is outside the boundaries of the array, print “Invalid index”

            if (idx < 0 || idx > numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }
            //•	exchange {index} – splits the array after the given index, and exchanges the places of the
            //two resulting sub-arrays. E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
            

            for (int rotation = 0; rotation < idx; rotation++)
            {
                int firstNumber = numbers[0];

                for (int i = 1; i < numbers.Length; i++)
                {
                    numbers[i - 1] = numbers[i];
                }

                numbers[numbers.Length - 1] = firstNumber;
            }
            
        }
    }
}
