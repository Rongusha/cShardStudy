using System;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine()
            .Split(", ")
            .ToArray();

            for (int i = 0; i < usernames.Length; i++)
            {
                string current = usernames[i];
                bool isValid = true;

                if (current.Length<3 || current.Length>16)
                {
                    isValid = false;
                }
                    
                for (int j = 0; j < current.Length; j++)
                {
                    if (!char.IsLetterOrDigit(current[j]) && current[j]!='-' && current[j]!='_')
                    {
                        isValid = false;
                        break;
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(current);
                }
            }
        }
    }
}
