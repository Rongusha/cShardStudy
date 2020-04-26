using System;

namespace Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var Firstname = Console.ReadLine();
            var Lastname = Console.ReadLine();
            var Age = Console.ReadLine();
            var Town = Console.ReadLine();
            Console.WriteLine($"You are {Firstname} {Lastname}, a {Age}-years old person from {Town}.");


        }
    }
}
