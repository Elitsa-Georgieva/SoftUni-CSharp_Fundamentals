using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Demage { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDemons = Console.ReadLine()
                .Split(',')
                .Select(e => e.Trim())
                .ToArray();

            Regex hpRegex = new Regex(@"[^\d\-+.*\/]");

            Regex numbersRegex = new Regex(@"[+\-]{0,1}\d+\.?\d*");

            Regex amlifaierRegex = new Regex(@"[*\/]");

            List<Demon> demons = new List<Demon>();

            foreach (var demon in inputDemons)
            {
                //int health = hpRegex.Matches(demon)
                //    .Select(m => char.Parse(m.Value))
                //    .Sum(x => x);
                MatchCollection hpMatches = hpRegex.Matches(demon);

                int health = GetHealth(hpMatches);

                MatchCollection numberMatches = numbersRegex.Matches(demon);
                //M3ph-0.5s-0.5t0.0**
                //3; -0.5; -0.5; 0.0

                double demage = GetBaseDemage(numberMatches);


                MatchCollection amplifaierMatches = amlifaierRegex.Matches(demon);

                foreach (Match match in amplifaierMatches)
                {
                    if (match.Value == "*")
                    {
                        demage *= 2;
                    }
                    else
                    {
                        demage /= 2;
                    }
                }

                demons.Add(new Demon
                    {
                        Name = demon,
                        Demage = demage,
                        Health = health
                    });
            }

            List<Demon> sorted = demons
                .OrderBy(d => d.Name)
                .ToList();

            foreach (Demon demon in sorted)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Demage:F2} damage");
            }
        }

        private static double GetBaseDemage(MatchCollection matchCollection)
        {
            double demage = 0;

            foreach (Match match in matchCollection)
            {
                demage += double.Parse(match.Value);
            }

            return demage;
        }

        private static int GetHealth(MatchCollection matchCollection)
        {
            int sum = 0;

            foreach (Match match in matchCollection)
            {
                sum += char.Parse(match.Value);
            }

            return sum;
        }
    }
}
