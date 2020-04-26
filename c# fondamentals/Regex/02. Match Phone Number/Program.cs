using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"\+359(\s|-)2\1\d{3}\1\d{4}\b");

            var input = Console.ReadLine();
            var maches = regex.Matches(input);

            Console.WriteLine(string.Join(", ", maches));
        }
    }
}
