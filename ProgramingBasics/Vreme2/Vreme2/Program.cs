using System;

namespace Vreme2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            if ((degrees >= 26) && (degrees <= 35.00))
                Console.WriteLine("Hot");
            else
            if ((degrees <= 25.9 ) && (degrees >= 20.1))
                Console.WriteLine("Warm");
            else
            if ((degrees <= 20) && (degrees >= 15))
                Console.WriteLine("Mild");
            else
            if ((degrees <= 14.9) && (degrees >= 12))
                Console.WriteLine("Cool");
            else
            if ((degrees <= 11.9) && (degrees >= 5.00))
                Console.WriteLine("Cold");
            else
                Console.WriteLine("unknown");
        }
    }
}
