using System;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split();

            int rotations = int.Parse(Console.ReadLine());
            for (int rotation = 0; rotation < rotations; rotation++)
            {
                string firstElement = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    int prevIndex = i - 1;
                    arr[prevIndex] = arr[i];

                }

                arr[arr.Length - 1] = firstElement;
            }

            foreach (var element in arr)
            {
                
                Console.Write($"{element} ");

            }

            Console.WriteLine();
        }
    }
}
