using System;

namespace LiceTriygylnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = a1 * h / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
