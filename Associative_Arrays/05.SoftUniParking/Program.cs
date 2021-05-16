using System;
using System.Collections.Generic;

namespace _05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                if (command == "register")
                {
                    string username = parts[1];
                    string licensePlateNum = parts[2];

                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNum}");
                    }
                    else
                    {
                        users.Add(username, licensePlateNum);
                        Console.WriteLine($"{username} registered {licensePlateNum} successfully");
                    }
                }
                else
                {
                    string username = parts[1];
                    bool removed = users.Remove(username);

                    if (removed)
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
