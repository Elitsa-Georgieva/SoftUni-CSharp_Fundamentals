using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            

            int countOfTargets = 0;
            int originN = N;

            while (N >= M)
            {
                //int newN = N - M;
                N -= M;
                
                countOfTargets++;

                if (N == originN/2 && Y != 0)
                {
                    N /= Y;
                }

            }

            Console.WriteLine(N);
            Console.WriteLine(countOfTargets);
        }
    }
}
