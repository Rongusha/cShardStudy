using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace _07StringExplosion
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var explosion = 0;

            for (int i = 0; i < text.Length; i++)
            {
                var current = text[i];
                if (explosion > 0 && current != '>')
                {
                    text = text.Remove(i, 1);
                    explosion--;
                    i--;
                }
                else if (current == '>')
                {
                    explosion += int.Parse(text[i + 1].ToString());
                }
            }

            Console.WriteLine(text);
        }
    }
}