using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a single string. Write a method that prints the middle character.
            //If the length of the string is even there are two middle characters.

            string str = Console.ReadLine();

            string middle = GetMiddle(str);

            Console.WriteLine(middle);

        }

        private static string GetMiddle(string str)
        {
            if (str.Length % 2 == 0)
            {
                return $"{str[str.Length / 2 - 1]}{str[str.Length / 2]}";
            }

            return $"{str[(str.Length - 1) / 2]}";
        }
    }
}
