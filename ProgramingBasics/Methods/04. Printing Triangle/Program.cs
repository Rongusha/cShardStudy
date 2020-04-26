using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int rows = 0; rows < number; rows++)
            {
                PrintTriangle(0, rows);

            }

            for (int cols = number -1 ; cols >= 0; cols--)
            {
                PrintTriangle(0, cols-1);
            }
        }

        static void PrintTriangle(int start, int end)
        {
            for (int rows = start; rows <= end; rows++)
            {
                Console.Write(rows + 1 + " ");
            }
            Console.WriteLine();
        }
    }
}
