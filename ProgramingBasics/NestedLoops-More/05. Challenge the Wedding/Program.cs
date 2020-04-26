using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int man = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int tableCount = 1;

            while (tableCount<=tables)
            {
               
                for (int m = 1; m <= man; m++)
                {
                    for (int w = 1; w <= woman; w++)
                    {
                        Console.Write($"({m} <-> {w}) ");
                        tableCount++;
                        if ((m==man && w==woman )|| tableCount>tables)
                        {
                            return;
                        }
                       
                    }
                }
            }
           

        }
    }
}
