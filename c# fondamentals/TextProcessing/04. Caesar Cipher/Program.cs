using System;
using System.Linq;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var toChars = text.ToArray();

            for (int i = 0; i < text.Length; i++)
            {
                int current = (int)text[i];
                current += 3;
               toChars[i] = (char)current;
            }

            Console.WriteLine(string.Join("",toChars));
        }
    }
}
