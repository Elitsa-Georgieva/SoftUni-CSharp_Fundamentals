using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([/\.\-/\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
            string dateString = Console.ReadLine();

            var dates = Regex.Matches(dateString, pattern);

            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
            

        }
    }
}
