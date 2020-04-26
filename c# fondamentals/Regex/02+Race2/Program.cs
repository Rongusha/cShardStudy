using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02_Race2
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .ToList();

            var letters = new List<char>();

            for (int i = 0; i < players.Count; i++)
            {
                letters.Add(players[i][0]);
            }

            var validPlayers = new Dictionary<string, int>();
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "end of race")
            {
                var playerLetter = ' ';
                for (int i = 0; i < command.Length; i++)
                {
                    if (char.IsLetter(command[i]) && char.IsUpper(command[i]))
                    {
                        playerLetter = command[i];
                        break;
                    }
                }
                if (letters.IndexOf(playerLetter) >= 0)
                {
                    var playerIndex = letters.IndexOf(playerLetter);
                    var currentPLayer = players[playerIndex];
                    var allChars = command.ToArray();
                    var digits = new List<int>();

                    for (int i = 0; i < allChars.Length; i++)
                    {
                        char current = allChars[i];

                        if (char.IsDigit(current))
                        {
                            digits.Add(int.Parse(current.ToString()));
                        }
                    }
                    if (validPlayers.ContainsKey(currentPLayer))
                    {
                        validPlayers[currentPLayer] += digits.Sum();//TODO: add all the digits in that line
                    }
                    else
                    {
                        validPlayers[currentPLayer] = digits.Sum();//TODO: add all the digits in that line
                    }
                }
            }

            validPlayers = validPlayers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);
            var validNames = new List<string>();

            foreach (var item in validPlayers)
            {
                validNames.Add(item.Key);
            }
            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"{i + 1}st place: {validNames[i]}");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"{i + 1}nd place: {validNames[i]}");
                }
                else
                {
                    Console.WriteLine($"{i + 1}rd place: {validNames[i]}");
                }

            }
        }
    }
}
