using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex keyRegex = new Regex(@"[STARstar]");

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();

                int key = keyRegex.Matches(text).Count;

                string decriptedText = Decript(text, key);

            }

            

            
        }

        private static string Decript(string text, int key)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in text)
            {
                sb.Append((char)letter - key);
            }

            return sb.ToString();
        }
    }
}
