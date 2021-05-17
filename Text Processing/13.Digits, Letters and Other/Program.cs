using System;
using System.Text;

namespace _05.Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that receives a single string and on the first line prints all the digits,
            //on the second – all the letters, and on the third – all the other characters.
            //There will always be at least one digit, one letter and one other characters.

            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder otherChars = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                else
                {
                    otherChars.Append(symbol);
                }
            }

            Console.WriteLine($"{digits}");
            Console.WriteLine($"{letters}");
            Console.WriteLine($"{otherChars}");
        }
    }
}
