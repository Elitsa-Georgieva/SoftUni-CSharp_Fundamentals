using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //A palindrome is a number which reads the same backward as forward such as 323 or 1001.
            //Write a program which reads a positive integer numbers until you receive "End",
            //for each number print whether the number is palindrome or not.

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                Console.WriteLine(IsPalindrom(command));
            }
        }
        private static bool IsPalindrom(string word)
        {
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}



            


