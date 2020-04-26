using System;

namespace Fuel
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFuel = Console.ReadLine();
            double litresOfFuel = double.Parse(Console.ReadLine());

            if ((typeOfFuel =="Diesel" || typeOfFuel =="Gasoline" || typeOfFuel=="Gas") && litresOfFuel >= 25)
            {
                string toLower = typeOfFuel.ToLower();
                Console.WriteLine($"You have enough {toLower}.");
            }
            else if ((typeOfFuel == "Diesel" || typeOfFuel == "Gasoline" || typeOfFuel == "Gas") && litresOfFuel < 25)
            {
                string toLower = typeOfFuel.ToLower();
                Console.WriteLine($"Fill your tank with {toLower}!");
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
         
        }
    }
}
