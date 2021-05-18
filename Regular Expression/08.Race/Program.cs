using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> racers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex nameRegex = new Regex(@"[A-Za-z]+");
            Regex digitsRegex = new Regex(@"\d");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of race")
                {
                    break;
                }

                MatchCollection letterMatches = nameRegex.Matches(line);
                MatchCollection digitMatches = digitsRegex.Matches(line);

                string name = GetName(letterMatches);
                int sum = GetSum(digitMatches);

                if (!racers.ContainsKey(name))
                {
                    continue;
                }

                racers[name] += sum;
            }

            string[] winners = racers
                .OrderByDescending(r => r.Value)
                .Take(3)
                .Select(r => r.Key)
                //kvp(името на състезателя и неговите км), вземи ми само string-а, което е само името(ключа)
                .ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");

        }

        private static int GetSum(MatchCollection matchCollection)
        {
            int sum = 0;

            foreach (Match match in matchCollection)
            {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static string GetName(MatchCollection matchCollection)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matchCollection)
            {
                sb.Append(match.Value);
            }

            return sb.ToString();
        }
    }
}
