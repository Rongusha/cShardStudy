using System;

namespace CelziiToFarenhain
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            //formula for converison °F = °C × 1,8 + 32

            double faren = (celsius * 1.8) + 32;
            Console.WriteLine($"{faren:f2}");
        }
    }
}
