using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    public class Person
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = parts[0];
                string id = parts[1];
                int age = int.Parse(parts[2]);

                Person person = new Person()
                {
                    Name = name,
                    Id = id,
                    Age = age
                };

                persons.Add(person);
            }

            List<Person> sorted = persons
                .OrderBy(x => x.Age)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, sorted));
        }
    }
}
