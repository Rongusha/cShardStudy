using System;

namespace _01.SingOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
             SignOfInt();
        }

        static void SignOfInt()
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
        }
    }
}
