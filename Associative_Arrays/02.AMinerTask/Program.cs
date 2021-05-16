using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //quantityByResourece - какво държим във Value-то под какъв Key
            Dictionary<string, int> quantityByResource = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (quantityByResource.ContainsKey(line))
                {
                    quantityByResource[line] += quantity;
                }
                else
                {
                    quantityByResource.Add(line, quantity);
                }
            }

            foreach (var kvp in quantityByResource)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
