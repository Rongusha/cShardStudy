using System;

namespace Reversing
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayToReverce = Console.ReadLine().Split();

            for (int i = 0; i < arrayToReverce.Length; i++)
            {
                Console.Write($"{arrayToReverce[arrayToReverce.Length - i - 1]} ");
            }
        }
    }
}
