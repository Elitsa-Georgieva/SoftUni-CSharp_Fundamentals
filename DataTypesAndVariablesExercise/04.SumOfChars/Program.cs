using System;

namespace _04.SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 'a'; i < 'a' + n; i++)
            //{
            //    for (int j = 'a'; j < 'a' + n; j++)
            //    {
            //        for (int k = 'a'; k < 'a' + n; k++)
            //        {
            //            Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
            //        }
            //    }
            //}

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());

                sum += symbol;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
