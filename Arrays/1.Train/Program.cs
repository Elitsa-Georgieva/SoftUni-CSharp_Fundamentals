using System;

namespace _1.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfVagon = int.Parse(Console.ReadLine());

            int[] peopleInVagoon = new int[countOfVagon];
            int sum = 0;

            for (int i = 0; i < peopleInVagoon.Length; i++)
            {


                peopleInVagoon[i] = int.Parse(Console.ReadLine());

                sum += peopleInVagoon[i];

            }

            for (int i = 0; i < peopleInVagoon.Length; i++)
            {

                Console.Write($"{peopleInVagoon[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
            
        }
    }
}
               
   