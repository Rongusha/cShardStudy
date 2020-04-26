using System;

namespace SquareMath
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = (Math.PI * r) * 2;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");



        }
    }
}
