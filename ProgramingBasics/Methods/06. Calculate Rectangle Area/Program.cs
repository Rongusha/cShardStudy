using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double resoult = RectangleArea(lenght, height);
            Console.WriteLine(resoult); 

        }

        static double RectangleArea (double lenght, double height)
        {
            double area = (lenght * height);
            return area;
        }
    }
}
