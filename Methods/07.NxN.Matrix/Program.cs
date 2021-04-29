using System;

namespace _07.NxN.Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a method that receives a single integer N and prints NxN matrix with that number.

            int N = int.Parse(Console.ReadLine());

            GetNxNMatrix(N);
            
        }

        private static void GetNxNMatrix(int number)
        {
            for (int row = 0; row < number; row++)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.Write($"{number} "); 
                }
                
                Console.WriteLine();
            }
        }
    }
}
