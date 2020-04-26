using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]{2,}\b");

            var text = Console.ReadLine();

            var maches = regex.Matches(text);

            Console.WriteLine(string.Join(" ", maches));
        }
    }
}
