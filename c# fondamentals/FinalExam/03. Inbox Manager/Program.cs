using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03._Inbox_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = new SortedDictionary<string, List<string>>();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                var splitted = input.Split("->").ToArray();
                var command = splitted[0];
                var username = splitted[1];

                switch (command)
                {
                    case "Add":
                        if (usernames.ContainsKey(username))
                        {
                            Console.WriteLine($"{username} is already registered");
                        }
                        else
                        {
                            usernames[username] = new List<string>();
                        }
                        break;

                    case "Send":

                        var email = splitted[2];

                        if (usernames.ContainsKey(username))
                        {
                            usernames[username].Add(email);
                        }
                        else
                        {
                            usernames[username] = new List<string>();
                            usernames[username].Add(email);
                        }
                        break;

                    case "Delete":
                        if (usernames.ContainsKey(username))
                        {
                            usernames.Remove(username);
                        }
                        else
                        {
                            Console.WriteLine($"{username} not found!");
                        }
                        break;
                }
            }
            var sorted = new Dictionary<string, List<string>>();

            sorted = usernames.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"Users count: {sorted.Keys.Count}");

            foreach (var user in sorted)
            {
                Console.WriteLine(user.Key);

                foreach (var email in user.Value)
                {
                    Console.WriteLine($"- {email}");
                }
            }
        }
    }
}
