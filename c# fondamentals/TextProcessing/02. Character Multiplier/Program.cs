using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var words =
            Console.ReadLine()
            .Split(" ")
            .ToArray();

            string first = words[0];
            string second = words[1];
            int sum = 0;
            int longer = Math.Max(first.Length, second.Length);
            int shorter = Math.Min(first.Length, second.Length);
            string bigger = second;

            if (first.Length > second.Length)
            {
                bigger = first;
            }
            for (int i = 0; i < shorter; i++)
            {
                int firstToInt = (int)first[i];
                int secondToInt = (int)second[i];
                sum += firstToInt * secondToInt;
            }

            for (int i = shorter; i < longer; i++)
            {
                int currentInt = (int)bigger[i];
                sum += currentInt;
            }

            Console.WriteLine(sum);
        }
    }
}
