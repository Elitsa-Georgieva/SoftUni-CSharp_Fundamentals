using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayerHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> winnersHand = new List<int>(firstPlayerHand.Count + secondPlayerHand.Count);

            while (true)
            {
                if (!GetWinner(firstPlayerHand, secondPlayerHand))
                {
                    if (firstPlayerHand[0] > secondPlayerHand[0])
                    {
                        firstPlayerHand.Add(firstPlayerHand[0]);
                        firstPlayerHand.Add(secondPlayerHand[0]);
                        firstPlayerHand.RemoveAt(0);
                        secondPlayerHand.RemoveAt(0);
                    }
                    else if (firstPlayerHand[0] == secondPlayerHand[0])
                    {
                        firstPlayerHand.RemoveAt(0);
                        secondPlayerHand.RemoveAt(0);
                    }
                    else
                    {
                        secondPlayerHand.Add(secondPlayerHand[0]);
                        secondPlayerHand.Add(firstPlayerHand[0]);
                        secondPlayerHand.RemoveAt(0);
                        firstPlayerHand.RemoveAt(0);
                    }
                }
                else
                {
                    //string winner = WinnersNumber(firstPlayerHand, secondPlayerHand);
                    int sum = PrintSum(winnersHand);

                    if (secondPlayerHand.Count <= 0)
                    {
                        winnersHand.AddRange(GetRemainingElements(firstPlayerHand, secondPlayerHand));
                        Console.WriteLine($"first player wins! Sum: {sum}");
                        break;
                    }
                    else
                    {
                        
                        winnersHand.AddRange(GetRemainingElements(secondPlayerHand, firstPlayerHand));
                        Console.WriteLine($"second player wins! Sum: {sum}");
                        break;
                    }
                }
            }

        }

        //private static string WinnersNumber(List<int> firstPlayerHand, List<int> secondPlayerHand)
        //{
        //    string winner = " ";
        //    if (secondPlayerHand.Count <= 0)
        //    {
        //        winner = "First";
        //    }
        //    else
        //    {
        //        winner = "Second";
        //    }

        //    return winner;
        //}

        private static int PrintSum(List<int> winnersHand)
        {
            int sum = 0;
            foreach (var num in winnersHand)
            {
                sum += num;
            }

            return sum;
        }

        private static IEnumerable<int> GetRemainingElements(List<int> longerList, List<int> shorterList)
        {
            List<int> winnersNewHand = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                winnersNewHand.Add(longerList[i]);
            }

            return winnersNewHand;
        }

        private static bool GetWinner(List<int> firstPlayerHand, List<int> secondPlayerHand)
        {
            return firstPlayerHand.Count <= 0 || secondPlayerHand.Count <= 0;
        }
    }
}
