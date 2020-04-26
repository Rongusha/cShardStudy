using System;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            //taxi price = 0.70 + 0.79/km day or 0.90/km night
            //bus price = 0.09/km but only for 20km +
            //train price = 0.06/km but only for 100km +

            int kilometers = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();

            if (kilometers < 20 && timeOfDay == "day") 
            {
                double TaxiFair = 0.70 + (kilometers * 0.79);
                Console.WriteLine($"{TaxiFair:f2}");

            }
            else if (kilometers < 20 && timeOfDay =="night")
            {
                double taxiFair = 0.70 + (kilometers * 0.90);
                Console.WriteLine($"{taxiFair:f2}");
            }
            else if (kilometers >= 20 && kilometers < 100)
            {
                
                double busFair = kilometers * 0.09;
                Console.WriteLine($"{busFair:f2}");
              
            }
            else if (kilometers  >= 100)
            {
                double trainFair = kilometers * 0.06;
                Console.WriteLine($"{trainFair:f2}");
            }
        }
    }
}
