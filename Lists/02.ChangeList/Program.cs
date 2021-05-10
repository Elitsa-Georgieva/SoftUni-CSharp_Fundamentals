using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {

                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                int element = int.Parse(parts[1]);


                if (command == "Delete")
                {
                    
                    numbers.RemoveAll(n => n == element);
                    //while (true)
                    //{
                    //    bool removed = numbers.Remove(element);

                    //    if (!removed)
                    //    {
                    //        break;
                    //    }
                    //}
                }
                else
                {
                    int idx = int.Parse(parts[2]);
                    numbers.Insert(idx, element);
                }
            }

            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
