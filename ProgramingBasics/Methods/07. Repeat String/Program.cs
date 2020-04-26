using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string resoult = TextRepeater(text, repeat);
        }

        static string TextRepeater (string text, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(text);
            }
            return text;
        }
    }
}
