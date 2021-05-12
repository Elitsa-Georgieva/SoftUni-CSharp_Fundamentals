using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    public class Team
    {
        //правим си този конструктор заради колекцията, за да не ни излезе тя със стойност null
        //а винаги дифолтната стойност да е празен лист
        public Team()
        {
            Members = new List<string>();
        }
        public string Name { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++)
            {
                string[] teamData = Console.ReadLine()
                    .Split('-');

                string creator = teamData[0];
                string teamName = teamData[1];

                //If а user tries to create a team more than once, a message should be displayed: 
                //-"Team {teamName} was already created!"

                Team existingTeam = GetTeamByNname(teams, teamName);

                //правим функция, която ще ни дава дали даден отбор съществува или не
                if (existingTeam != null)
                {
                    //ако функцията ни е върнала true - такъв отбор съществува =>
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (CreatorExists(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;

                    //Didi-otborNqkakyv
                    //Team otborNqkakyv was created!
                    //Didi-nov otbor
                    //Didi cannot create another team!
                }

                //ако ни е върнала, че НЕ съществуеа, създаваме си нов Team със стойности creator и teamName
                Team team = new Team
                {
                    Creator = creator,
                    Name = teamName,
                };
                //и след като си го създадохме, добавяме го към листа с отбори
                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");

            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of assignment")
                {
                    break;
                }

                string[] parts = line.Split("->");

                string user = parts[0];
                string teamName = parts[1];

                //правим функция, която ще обходи всички отботи и ще търси този отбор, който има това име teamName
                Team existingTeam = GetTeamByNname(teams, teamName);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (IsMember(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                existingTeam.Members.Add(user);

            }

            List<Team> sorted = teams
                    //сортирай ми отборите по броя на техните участници в низходящ ред
                .OrderByDescending(t => t.Members.Count)
                    //ако два отбора са с един и същ брои, тогава сортирай по име
                .ThenBy(t => t.Name)
                .ToList();

            foreach (var team in sorted)
            {

                if (team.Members.Count == 0)
                {
                    break;
                }

                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                List<string> sortedMembers = team.Members
                    .OrderBy(m => m)
                    .ToList();

                foreach (var member in sortedMembers)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            {
                
            }

            List<Team> disbandedTeams = teams
                    //мини през отборите, които имахме до сега и за тези, чиито members.Count е равно на
                    //0. ми ги запази в тази променлива List
                    //това ще са всички отбори, които трябва да разформираме
                    .Where(x => x.Members.Count == 0)
                    .OrderBy(t => t.Name)
                    .ToList();

            Console.WriteLine($"Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }
        }

        private static Team GetTeamByNname(List<Team> teams, string teamName)
        {
            foreach (Team team in teams)
            {
                if (team.Name == teamName)
                {
                    return team;
                }
            }

            return null;
        }

        private static bool IsMember(string user, List<Team> teams)
        {
            foreach (var team in teams)
            {
                //за всеки един отбор проверяваме неговия creator
                //до някаква степен да си creator на отбор означава, че си и негов член, само че си с друга функция
                if (team.Creator == user)
                {
                    return true;
                }
                //второ, проверяваме всички участници в този отбор
                //което ще ни върне списък от стрингове и за всеки member ще проверим дали не е този user
                foreach (var member in team.Members)
                {
                    if (user == member)
                    {
                        return true;
                    }
                }
            }
                // ако в двата горни случая не сме върнали true, а сме обходили всички отбори с всички техни участници
                // означава, че реално този човек го срещаме за първи път
                return false;

            
        }

        private static bool CreatorExists(List<Team> teams, string creator)
        {
            foreach (var team in teams)
            {
                //ako creator се опитва да направи нов отбор, но вече е създавал отбор, който има същия creator като
                //този в този метод, връщаме true
                if (team.Creator == creator)
                {
                    return true;
                }
            }
            //в противен случай връщаме false, т.е. този човек до сега не е бил creator на отбор
            return false;
        }

    }
}
