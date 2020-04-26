using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string toType = Console.ReadLine();

            if (type == "mm" && toType == "cm")
            {
                double convert = num1 / 10;
                Console.WriteLine($"{convert:f3}");
            }

            else if (type == "mm" && toType =="m")
            {
                double convert = num1 / 1000;
                Console.WriteLine($"{convert:f3}");
            }
            else if (type =="cm" && toType == "mm")
            {
                double convert = num1 * 10;
                Console.WriteLine($"{convert:f3}");
            }
            else if (type =="cm" && toType=="m")
            {
                double convert = num1 / 100;
                Console.WriteLine($"{convert:f3}");
            }
            else if (type =="m" && toType=="mm")
            {
                double convert = num1 * 1000;
                Console.WriteLine($"{convert:f3}");
            }
            else if (type == "m" && toType=="cm")
            {
                double convert = num1 * 100;
                Console.WriteLine($"{convert:f3}");
            }

        }
    }
}
