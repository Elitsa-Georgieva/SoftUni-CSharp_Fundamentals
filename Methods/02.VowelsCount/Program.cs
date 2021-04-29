using System;
using System.Diagnostics.Tracing;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a single string and prints the count of the vowels.
            //Use appropriate name for the method.

            string str = Console.ReadLine();

            int vowelsCount = GetVowels(str);

            Console.WriteLine(vowelsCount);
        }

        private static int GetVowels(string str)
        {
            int counter = 0;

            str = str.ToLower();

            foreach (char letter in str)
            {
                if (letter == 'a' ||
                    letter == 'o' ||
                    letter == 'u' ||
                    letter == 'e' ||
                    letter == 'i' ||
                    letter == 'y')
                {
                    counter += 1;
                }
            }

            return counter;
        }
    }
}
