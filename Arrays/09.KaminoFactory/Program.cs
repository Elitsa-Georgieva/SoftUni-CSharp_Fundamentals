using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them")
                {
                    break;
                }

                int[] sequence = line
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // вадим за първия масив (0!1!1!0!0) неговата най-добра подредица (7-ма задача - 
                // там търсехме еднакви числа, най-дългата подредица от еднакви числа)



            }
        }
    }
}
