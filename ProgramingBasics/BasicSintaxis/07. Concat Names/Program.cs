using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string connection = Console.ReadLine();

            Console.WriteLine($"{name1}{connection}{name2}");
        }
    }
}
