using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var regex = new Regex(@"U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}\d+)P@\$");
            var input = string.Empty;
            var successfulRegistrations = new List<string>();

            for (int i = 0; i < num; i++)
            {
                input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    var username = match.Groups["username"].Value;
                    var password = match.Groups["password"].Value;

                    successfulRegistrations.Add(username);

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrations.Count}");
        }
    }
}
