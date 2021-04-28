using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            double min = minutes + 30;

            if (min > 59 )
            {
                hour += 1;
                min -= 60;
            }
            if (hour > 23)
            {
                hour -= 24;
            }
            if (min < 10)
            {
            //Console.WriteLine($"{hour}:0{min}");

            //}
                Console.WriteLine($"{hour}:{min:D1}");
            }

            else
            {
                Console.WriteLine($"{hour}:{min}");
            }

            
        }
    }
}
