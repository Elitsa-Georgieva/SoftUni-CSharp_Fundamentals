using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = parts[0];
                string employeeId = parts[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string>());
                }

                // employeesByCompany[company] - s towa dostypvame Value-то(в случая празен списък, който създадохме
                //ред нагоре
                companies[company].Add(employeeId);
            }


            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                List<string> uniqueEmployee = company.Value
                    .Distinct()
                    .ToList();

                foreach (var employee in uniqueEmployee)
                {
                    Console.WriteLine($"-- {employee}");
                }

            }
        }
    }
}
