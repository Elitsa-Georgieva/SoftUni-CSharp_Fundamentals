using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> membersBySide = new Dictionary<string, List<string>>();

            Dictionary<string, string> members = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains(" | "))
                {
                    string[] parts = line.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                    string forseSide = parts[0];
                    string forseUser = parts[1];

                    if (members.ContainsKey(forseUser))
                    {
                        continue;
                    }

                    if (!membersBySide.ContainsKey(forseSide))
                    {
                        membersBySide.Add(forseSide, new List<string>());
                    }

                    membersBySide[forseSide].Add(forseUser);
                    members.Add(forseUser, forseSide);
                }
                else
                {
                    string[] parts = line.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                    string forseSide = parts[1];
                    string forseUser = parts[0];

                    // гарантираме си, че ако такъв Side  не съществува, ние ще си го добавим(създадем) с ключ
                    // forseSide и Value празен Лист
                    if (!membersBySide.ContainsKey(forseSide))
                    {
                        membersBySide.Add(forseSide, new List<string>());
                    }

                    if (members.ContainsKey(forseUser))
                    {
                        // ако members  съдържа такъв forseUser  трябва да му сменим страната (forseSide-a)

                        // за целта първо взимаме старата му страна
                        //members[от текущия forceUser]
                        // в members ние попълвахме кой User от кой Side е участник
                        string oldSide = members[forseUser];

                        //
                        membersBySide[oldSide].Remove(forseUser);
                        //това което сме получили от командата - новия side, към който трябва да добавим user-а
                        membersBySide[forseSide].Add(forseUser);
                        // и сега казваме, че за този member, ние сме му променили Side-а. Тук forceSide е част
                        // от самите входни данни.
                        members[forseUser] = forseSide;
                    }
                    else
                    {
                        //ако не съществува такъв user
                        //добавяме си го в membersBySide на ключ forseSice
                        membersBySide[forseSide].Add(forseUser);
                        // добавяме си го и в members речника
                        members.Add(forseUser, forseSide);
                    }

                    Console.WriteLine($"{forseUser} joins the {forseSide} side!");
                }
            }

            Dictionary<string, List<string>> result = membersBySide
                .Where(s => s.Value.Count > 0)
                .OrderByDescending(s => s.Value.Count)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var member in kvp.Value)
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
