using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstChar = 0;
            int secontChar = 0;
            for (int i = 1; i <= num; i++)
            {
                firstChar = i / 10;
                secontChar = i % 10;

                if ((firstChar+secontChar==5)||(firstChar+secontChar==7)||(firstChar+secontChar==11))
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
