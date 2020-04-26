using System;
using System.Text.RegularExpressions;

namespace p03SoftUniBarIncome
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var regex = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(\.\d+)?)[$]";
            var totalSum = 0.0;
            var command = string.Empty;

            while ((command= Console.ReadLine())!= "end of shift")
            {
               
                var matched = Regex.Matches(command, regex);

                foreach (Match match in matched)
                {
                    var name = match.Groups["name"].Value;
                    var product = match.Groups["product"].Value;
                    var count = match.Groups["count"].Value;
                    var price = match.Groups["price"].Value;
                    var sum = int.Parse(count) * double.Parse(price);
                    totalSum += sum;

                    Console.WriteLine($"{name}: {product} - {sum:F2}");
                }
            }

            Console.WriteLine($"Total income: {totalSum:F2}");
        }
    }
}