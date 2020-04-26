using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var toChars = text.ToList();
            var builder = new StringBuilder();

            for (int i = 0; i < toChars.Count - 1; i++)
            {
                char current = toChars[i];
                char nextTo = toChars[i + 1];

                if (current != nextTo)
                {
                    builder.Append(current);
                }
            }

            builder.Append(toChars[toChars.Count - 1]);

            Console.WriteLine(builder);
        }
    }
}
