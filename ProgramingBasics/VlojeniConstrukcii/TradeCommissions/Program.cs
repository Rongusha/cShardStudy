using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (money >= 0 && money <= 500)
                {
                    double bonus = money * 0.05;
                    Console.WriteLine($"{bonus:f2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    double bonus = money * 0.07;
                    Console.WriteLine($"{bonus:f2}");

                }
                else if (money > 1000 && money <= 10000)
                {
                    double bonus = money * 0.08;
                    Console.WriteLine($"{bonus:f2}");
                }
                else if (money > 10000)
                {
                    double bonus = money * 0.12;
                    Console.WriteLine($"{bonus:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Varna")
            {
                if (money >= 0 && money <= 500)
                {
                    double bonus = money * 0.045;
                    Console.WriteLine($"{bonus:f2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    double bonus = money * 0.075;
                    Console.WriteLine($"{bonus:f2}");

                }
                else if (money > 1000 && money <= 10000)
                {
                    double bonus = money * 0.10;
                    Console.WriteLine($"{bonus:f2}");
                }
                else if (money > 10000)
                {
                    double bonus = money * 0.13;
                    Console.WriteLine($"{bonus:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "Plovdiv")
            {
                if (money >= 0 && money <= 500)
                {
                    double bonus = money * 0.055;
                    Console.WriteLine($"{bonus:f2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    double bonus = money * 0.08;
                    Console.WriteLine($"{bonus:f2}");

                }
                else if (money > 1000 && money <= 10000)
                {
                    double bonus = money * 0.12;
                    Console.WriteLine($"{bonus:f2}");
                }
                else if (money > 10000)
                {
                    double bonus = money * 0.145;
                    Console.WriteLine($"{bonus:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
