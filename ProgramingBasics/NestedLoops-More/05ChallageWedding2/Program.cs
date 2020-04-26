using System;

namespace _05ChallageWedding2
{
    class Program
    {
        static void Main(string[] args)
        {
            int man = int.Parse(Console.ReadLine());
            int woman = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int m = 0;
            int w = 0;
            for (int t = 1; t <= tables;)
            {
                if ((m > man && w > woman))
                {
                    return;
                }
                for ( m = 1; m <= man; m++)
                {
                    for ( w = 1; w <= woman; w++)
                    {
                        if (t>tables)
                        {
                            return;
                        }
                        Console.Write($"({m} <-> {w}) ");
                        t++;
                    }
                }
            }
        }
    }
}
