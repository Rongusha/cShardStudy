using System;

namespace SquareMath
{
    class Program
    {
        static void Main(string[] args)
        {

            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var width = Math.Max(x1, x2) - Math.Min(x1, x2);
            var Height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine( width * Height);
            Console.WriteLine( 2 * (width + Height));



        }
    }
}
