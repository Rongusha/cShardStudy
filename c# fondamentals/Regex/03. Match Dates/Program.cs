using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b(\d{2})(\.|\/|-)([A-Z][a-z]{2})\2(\d{4})\b");

            var input = Console.ReadLine();
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var day = match.Groups[1].Value;
                var month = match.Groups[3].Value;
                var year = match.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
