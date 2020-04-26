using System;

namespace FuelPump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Price petrol 2.22/ltr if discount 0.18/ltr
            //price diesel 2.33/ltr if discount 0.12/ltr
            //price gas 0.93/ltr if discount 0.08/ltr
            //8% discount for between 20 and 25 ltr
            //10% discount for more than 25 ltr

            string typeOfFuel = Console.ReadLine();
            double litresOfFuel = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double petrolPrice = litresOfFuel * 2.22;
            double dieselPrice = litresOfFuel * 2.33;
            double gasPrice = litresOfFuel * 0.93;
           


            if (card == "Yes")
            {
                petrolPrice = litresOfFuel * 2.04;
                dieselPrice = litresOfFuel * 2.21;
                gasPrice = litresOfFuel * 0.85;
                



            }
            if (litresOfFuel >= 20 && litresOfFuel <= 25)
            {
                petrolPrice = petrolPrice - (0.08 * petrolPrice);
                dieselPrice = dieselPrice - (0.08 * dieselPrice);
                gasPrice = gasPrice - (0.08 * gasPrice);
               

            }
            else if (litresOfFuel > 25)
            {
                petrolPrice = petrolPrice - (0.10 * petrolPrice);
                dieselPrice = dieselPrice - (0.10 * dieselPrice);
                gasPrice = gasPrice - (0.10 * gasPrice);
                

            }
            if (typeOfFuel == "Gas")
            {
                Console.WriteLine($"{gasPrice:f2} lv.");
            }
            else if (typeOfFuel == "Gasoline")
            {
                Console.WriteLine($"{petrolPrice:f2} lv.");
            }

            else if (typeOfFuel == "Diesel")
            {
                Console.WriteLine($"{dieselPrice:f2} lv.");
            }

        }
    }
}
