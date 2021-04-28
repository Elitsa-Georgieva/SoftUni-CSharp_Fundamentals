using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            

            do
            {
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");
                num2 ++;
            }
            while (num2 <= 10);

        }
    }
}
