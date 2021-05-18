using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = //@"(\+359([ -])2(\2)(\d{3})(\2)(\d{4}))\b";
                           @"(\+[0-9]+([ -])\d?(\2)([0-9]{3})(\2)([0-9]{4}))\b";
            //(\+[0-9]+([ -])\d?(\2)([0-9]{3})(\2)([0-9]{4}))\b
            //group 1: +359-2-222-2222 group 2: - group 3: - group 4: 222 group 5: - group 6: 2222
            string phoneNumbers = Console.ReadLine();

            MatchCollection phoneMatches = Regex.Matches(phoneNumbers, pattern);

            List<string> phoneList = new List<string>();

            foreach (var phone in phoneMatches)
            {
                phoneList.Add(phone.ToString());
            }

            Console.WriteLine(string.Join(", ", phoneList));


            //LINQ решение: 

            //var matchPhoneNumbers = phoneMatches
            //    .Cast<Match>()
            //    .Select(a => a.Value.Trim())
            //    .ToArray();

            //Console.WriteLine(string.Join(", ", matchPhoneNumbers));
        }
    }
}
