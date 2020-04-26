using System;

namespace Divide_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double p1Count = 0;
            double p2Count = 0;
            double p3Count = 0;
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    p1Count++;
                }
                if (num % 3 == 0)
                {
                    p2Count++;
                }
                if (num % 4 == 0)
                {
                    p3Count++;
                }
            }
            p1 = p1Count / count * 100;
            p2 = p2Count / count * 100;
            p3 = p3Count / count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
