using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var text = string.Empty;
            var regex = new Regex(@"@(?<planet>[A-Za-z]+)[^\@\-!:>]*:(?<population>\d+)[^\@\-!:>]*!(?<attack>[A|D]{1})![^\@\-!:>]*->(?<soldiers>\d+)");
            var attackedPlanets = new List<string>();
            var destroyedPlanets = new List<string>();

            for (int i = 0; i < num; i++)
            {
                text = Console.ReadLine();
                var textToChars = text.ToArray();
                var couted = textToChars.Where(x => x == 's' || x == 't' || x == 'a' || x == 'r' || x == 'S' || x == 'T' || x == 'A' || x == 'R').ToArray();
                var deduct = couted.Length;

                for (int j = 0; j < textToChars.Length; j++)
                {
                    var charAsNum = (int)textToChars[j];
                    charAsNum -= deduct;
                    var newChar = (char)charAsNum;
                    textToChars[j] = newChar;
                }

                text = string.Join("", textToChars);
                var match = regex.Match(text);

                if (match.Success)
                {
                    var planet = match.Groups["planet"].Value;
                    var population = int.Parse(match.Groups["population"].Value);
                    var attack = char.Parse(match.Groups["attack"].Value);
                    var soldiers = int.Parse(match.Groups["soldiers"].Value);

                    if (attack == 'A')
                    {
                        attackedPlanets.Add(planet);
                    }
                    else
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            attackedPlanets = attackedPlanets.OrderBy(x => x).ToList();
            destroyedPlanets = destroyedPlanets.OrderBy(x => x).ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            if (attackedPlanets.Count >= 0)
            {
                foreach (var item in attackedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            if (destroyedPlanets.Count >= 0)
            {
                foreach (var item in destroyedPlanets)
                {
                    Console.WriteLine($"-> {item}");
                }
            }
        }
    }
}
