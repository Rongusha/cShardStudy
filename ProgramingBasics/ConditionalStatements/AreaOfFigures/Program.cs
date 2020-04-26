using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side1 = double.Parse(Console.ReadLine());
                double area = side1 * side1;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double area = side1 * side2;
                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double area = Math.PI * (side1 * side1);
                Console.WriteLine($"{area:f3}");
            }
            else if (figure =="triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                double area = (side1 * h) / 2;
                Console.WriteLine($"{area:f3}");
            }

        }
    }
}
