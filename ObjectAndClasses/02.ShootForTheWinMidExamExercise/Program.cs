using System;
using System.Linq;

namespace _02.ShootForTheWinMidExamExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int counter = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                     Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', sequence));
                     break;
                }

                int idxTarget = int.Parse(command);
                if (idxTarget >= 0 && idxTarget < sequence.Length)
                {
                    for (int i = 0; i < sequence.Length; i++)
                    {
                        int temp = sequence[idxTarget];
                        if (sequence[i] != -1 && i != idxTarget)
                        {
                            if (sequence[i] > temp)
                            {
                                sequence[i] -= temp;
                            }
                            else if (sequence[i] <= temp)
                            {
                                sequence[i] += temp;
                            }
                        }
                    }

                    sequence[idxTarget] = -1;
                    counter++;
                }
            }
        }
    }
}
