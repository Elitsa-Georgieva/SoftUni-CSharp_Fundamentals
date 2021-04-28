using System;

namespace _1_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            double Grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade:F2}");
        }
    }
}
