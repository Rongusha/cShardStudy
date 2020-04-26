using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());



            double p1Count = 0;//num<200
            double p2Count = 0;//>=200 < 399
            double p3Count = 0;//>=400 < 599
            double p4Count = 0;//>=600 < 799
            double p5Count = 0;//num >= 800
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < count ; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1Count++;
                }
                else if (num >= 200 && num <= 399)
                {
                    p2Count++;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3Count++;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4Count++;
                }
                else if (num >= 800)
                {
                    p5Count++;
                }

            }
            p1 = p1Count / count * 100;
            p2 = p2Count / count * 100;
            p3 = p3Count / count * 100;
            p4 = p4Count / count * 100;
            p5 = p5Count / count * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
