using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int bestSequenceSize = 0;
            int bestSequenceNumber = 0;
            int babiniDevitini = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNum = numbers[i];
                int sequenceSize = 1;

                for (int j = i+1; j < numbers.Length; j++)
                    //почваме от i + 1 = първото дясно число
                {
                    int rightNumber = numbers[j];

                    if (currentNum == rightNumber)
                    {
                        sequenceSize += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (sequenceSize > bestSequenceSize)
                {
                    bestSequenceSize = sequenceSize;
                    bestSequenceNumber = currentNum;
                }
            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write($"{bestSequenceNumber} ");
            }

            Console.WriteLine();
        }
    }
}
