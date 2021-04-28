using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int times = 1;
            

            while (times <= 10)
            {
                Console.WriteLine($"{integer} X {times} = {integer*times}");
                times++;    
            }
        }
    }
}
