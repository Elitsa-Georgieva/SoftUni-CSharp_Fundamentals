using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            int n = int.Parse(Console.ReadLine());
            
            int litersInTank = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                litersInTank += liters;
                capacity -= liters;

                
            }


            Console.WriteLine(litersInTank);

            //while(true)
            //{
            //    litersInTank += liters;

            //    if (litersInTank > capacity)
            //    {
            //        Console.WriteLine("Insufficient capacity!");
                    
            //    }

            //    liters = int.Parse(Console.ReadLine());

            //}
        }
    }
}
