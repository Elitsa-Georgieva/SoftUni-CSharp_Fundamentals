using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentsByCourse = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string course = parts[0];
                string student = parts[1];

                if (!studentsByCourse.ContainsKey(course))
                {
                    studentsByCourse.Add(course, new List<string>());
                }

                // studentsByCourse[course] - s towa dostypvame Value-то(в случая празен списък, който създадохме
                //ред нагоре
                studentsByCourse[course].Add(student);
                //използвай ми списъка, който стои срещу този ключ[course]  в речника studentsByCourse и към него
                // добави студента, който получихме от parts[1]  от конзолата сега.


            }

            Dictionary<string, List<string>> sortedCourses = studentsByCourse
                .OrderByDescending(c => c.Value.Count)
                //(за всеки курс искаме да го сортираме като достъпим value-то - x => x.Value - това до тук обаче връща списък и 
                // но за целта ни е необходима бройката в списъка, затова ползваме Value.Count - count пропъртито на списъка.
                .ToDictionary(x => x.Key, x => x.Value);

            //направихме нов речник със същите структура и данни, но сортирани в ред какъвто ние сме оказали.

            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                List<string> sortedStudents = kvp.Value
                    .OrderBy(s => s)
                    .ToList();

                //СЪЩОТО КАТО: 
                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
