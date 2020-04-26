using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double resoult = RaiseToPower(number, power);

            Console.WriteLine(resoult);
        }

        static double RaiseToPower (double number, double power)
        {
            // double resoult = Math.Pow(number, power);
            double resoult = 1;
            for (int i = 0; i < power; i++)
            {
               
                resoult *= number;
            }
           

            return resoult;

        }
    }
}
