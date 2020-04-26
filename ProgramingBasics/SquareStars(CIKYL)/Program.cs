using System;

namespace SquareStars_CIKYL_
{
    class Program
    {


        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("*");
                for (int a = 0; a < n - 2; a++)
                {
                    Console.Write(" ");
                    
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < n; i++)
                Console.Write("*");
            {
                Console.WriteLine();
            }
        }
    }
}

