using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            //string rmWord = Console.ReadLine();
            //string input = Console.ReadLine();

            //while (input.Contains(rmWord))
            //{
            //    input = input.Replace(rmWord, string.Empty);
            //}

            //Console.WriteLine(input);

            string rmWord = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(rmWord))
            {
                int idx = text.IndexOf(rmWord);
                text = text.Remove(idx, rmWord.Length);
            }

            Console.WriteLine(text);
        }
    }
}
