using System;

namespace _02.CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();

            foreach (string itemSecond in secondArray)
            {
                foreach (string itemFirst in firstArray)
                {
                    if(itemFirst == itemSecond)
                    {
                        Console.Write($"{itemSecond} ");
                    }
                }
            }
        }
    }
}
