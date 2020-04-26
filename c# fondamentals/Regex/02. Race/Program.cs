using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<letter>^[A-Za-z])?(?<digits>\d)");
            
            var validPlayers = new Dictionary<string, int>();
            var allMaches = new List<Char>();

            var players = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var letters = new List<char>();

            for (int i = 0; i < players.Count; i++)
            {
                letters.Add(players[i][0]);
            }

            var command = string.Empty;

            while ((command = Console.ReadLine()) != "end of race")
            {
                var match = regex.Match(command);
                if (match.Success)
                {
                    var currentPlayerLetter =Char.Parse(match.Groups["letter"].Value);
                    var currentPlayerDistance = char.Parse(match.Groups["digits"].Value);
                    var currentPlayerIndex = letters.IndexOf(currentPlayerLetter);
                    var currentPlayerName = players[currentPlayerIndex];

                    if (currentPlayerIndex >= 0)
                    {
                        if (validPlayers.ContainsKey(currentPlayerName))
                        {
                            //validPlayers[currentPlayerName] += 
                        }
                    }
                }
            }
        }
    }
}
