using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            

            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                   double sumPrice = quantity * 2.70;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "apple")
                {
                    double sumPrice = quantity * 1.25;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "orange")
                {
                    double sumPrice = quantity * 0.90;
                    Console.WriteLine($"{sumPrice:f2}");

                }
                else if (fruit == "grapefruit")
                {
                    double sumPrice = quantity * 1.60;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double sumPrice = quantity * 3.00;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double sumPrice = quantity * 5.60;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "grapes")
                {
                    double sumPrice = quantity * 4.20;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
                
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday " || day == "Friday")
            {
                if (fruit == "banana")
                {
                    double sumPrice = quantity * 2.50;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "apple")
                {
                    double sumPrice = quantity * 1.20;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "orange")
                {
                    double sumPrice = quantity * 0.85;
                    Console.WriteLine($"{sumPrice:f2}");

                }
                else if (fruit == "grapefruit")
                {
                    double sumPrice = quantity * 1.45;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "kiwi")
                {
                    double sumPrice = quantity * 2.70;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "pineapple")
                {
                    double sumPrice = quantity * 5.50;
                    Console.WriteLine($"{sumPrice:f2}");
                }
                else if (fruit == "grapes")
                {
                    double sumPrice = quantity * 3.85;
                    Console.WriteLine($"{sumPrice:f2}");
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
