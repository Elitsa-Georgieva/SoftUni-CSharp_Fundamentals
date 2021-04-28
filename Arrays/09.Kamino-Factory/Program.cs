using System;
using System.Linq;
using System.Text.Json;

namespace _09.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int bestSequenceSize = 0;
            int bestSequenceStartingIndex = 0;
            int bestSequenceSum = 0;
            int[] bestSequence = new int[size];
            int bestSample = 0;

            int sample = 0;

            while (true)
            {
                string line = Console.ReadLine();

                sample += 1;

                if (line == "Clone them!")
                {
                    break;
                }

                int[] sequence = line
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sequenceSum = 0;
                foreach (var number in sequence)
                {
                  sequenceSum += number;
                }

                for (int i = 0; i < sequence.Length; i++)
                {
                    int currentNumber = sequence[i];
                    if (currentNumber == 0)
                    {
                        continue;
                    }

                    int currentSequenceSize = 1;

                    
                    for (int j = i + 1; j < sequence.Length ; j++)
                    {
                        if (currentNumber == sequence[j])
                        {
                            currentSequenceSize += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    // след като приключим това цялото нещо, проверяваме дали този sequence, който сме открили,
                   // реално е най-добрия от всичките. Декларираме си една променлива int bestSequenceSize = 0;
                   // т.к. може да имаме еднакво дълги sequence в двата масива, правим още една променлива за стартов индекс на
                   // поредицата ->  int bestSequenceStartingIndex = 0;

                //След като сме открили най-добрата подредица на currentNumber можем да проверим дали currentSequenceSize
                // e по-голямо от bestSequenceSize;

                    if (currentSequenceSize > bestSequenceSize)
                    {
                        bestSequenceSize = currentSequenceSize;
                        bestSequenceStartingIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSequence = sequence;
                        bestSample = sample;
                        // т.е. и-тия индекс ми е новият най-добър индекс от където започва тази подредица
                    }
                    else if(currentSequenceSize == bestSequenceSize)
                    {
                        // за да получим нова най-добра подредица, ако имат еднакви еднаква размери, проверяваме дали
                        // текущото i е по-малко от най-добрия ни стартов Индекс - 0 1 1 0 0 - започва от индекс [1], а 
                        // 0 0 1 1 0 - започва от индекс [2] следователно правим още една if проверка ->  дали i-то е по-малко 
                        // от bestSequenceStartingIndex -> ако е така :

                        if (i < bestSequenceStartingIndex)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSequence = sequence;
                            bestSample = sample;
                        }
                        else if (i == bestSequenceStartingIndex && sequenceSum > bestSequenceSum)
                        {
                            //тука имаме нов кейс - да проверим дали текущият масив има по-добра сума от най-добрия масив. Правим
                            //нова променлива int bestSequenceSum = 0; 

                            //правим int sequenceSum = 0; 
                            //foreach (var number in sequence)
                            //{
                            //  sequenceSum += number;
                            //}
                            // всяко едно число от sequence го добави към сумата

                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSequence = sequence;
                            bestSample = sample;
                        }
                    }
                }

            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
