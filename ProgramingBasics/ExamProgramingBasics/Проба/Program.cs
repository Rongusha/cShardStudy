using System;

namespace Проба
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "End")
            {
                int people = int.Parse(command);
                command = Console.ReadLine();
            }
        }
    }
}
