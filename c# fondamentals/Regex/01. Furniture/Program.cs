using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var item = string.Empty;
            var price = 0.0;
            var items = new List<string>();
            var regex = new Regex(@"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>[0-9]+\.?[0-9]*|\d+)[!](?<quantity>\d+)");

            while ((input = Console.ReadLine()) != "Purchase")
            {
                var matches = regex.Matches(input);
                if (regex.IsMatch(input))
                {
                    foreach (Match match in matches)
                    {
                        item = match.Groups["name"].Value;
                        price += (double.Parse(match.Groups["price"].Value) * int.Parse(match.Groups["quantity"].Value));
                        items.Add(item);
                    }
                }
            }
            
            Console.WriteLine("Bought furniture:");

            foreach (var furniture in items)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}
