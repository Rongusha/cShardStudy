using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Numerics;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var emojiRegex = new Regex(@"(::|\*\*)(?<Emoji>[A-Z][a-z]{2,})\1");
            var coolRegex = new Regex(@"\d");
            var numbers = new List<int>();
            long sumRequired = 1;
            var matches = coolRegex.Matches(text);

            foreach (Match match in matches)
            {
                numbers.Add(int.Parse(match.Value));
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                sumRequired *= numbers[i];
            }

            Console.WriteLine($"Cool threshold: {sumRequired}");

            matches = emojiRegex.Matches(text);
            var emojies = new List<string>();
            var fullMatches = new List<string>();

            foreach (Match match in matches)
            {
                var currentEmoji = match.Groups["Emoji"].Value;
                var currentSymbol = match.Groups[1].Value;
                fullMatches.Add(currentSymbol + currentEmoji + currentSymbol);
                emojies.Add(currentEmoji);
            }


            Console.WriteLine($"{fullMatches.Count} emojis found in the text. The cool ones are:");

            foreach (var item in emojies)
            {
                var sum = GetSumOfChars(item);

                if (sum < sumRequired)
                {
                    var index = emojies.IndexOf(item);
                    fullMatches.RemoveAt(index);
                }
            }



            foreach (var item in fullMatches)
            {
                Console.WriteLine(item);
            }


        }

        static int GetSumOfChars(string emoji)
        {
            var sum = 0;
            for (int i = 0; i < emoji.Length; i++)
            {
                var currentChar = (int)emoji[i];
                sum += currentChar;
            }

            return sum;
        }
    }
}
