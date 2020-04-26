using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = Char.Parse(Console.ReadLine());
            var secondChar = Char.Parse(Console.ReadLine());
            var text = Console.ReadLine();
            var askiSum = new List<int>();
            var firstCharAski = (int)firstChar;
            var secondCharAski = (int)secondChar;
            var textAsAski = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                var result = (int)text[i];
                textAsAski.Add(result);
            }

            for (int i = 0; i < textAsAski.Count; i++)
            {
                if (textAsAski[i] > firstCharAski && textAsAski[i] < secondCharAski)
                {
                    askiSum.Add(textAsAski[i]);
                }
            }

            Console.WriteLine(askiSum.Sum());
        }
    }
}
