using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            //Premiere == 12 lv.
            //Normal == 7.50 lv
            //Discount == 5 lv.
            int numRolls = int.Parse(Console.ReadLine());
            int numColloms = int.Parse(Console.ReadLine());

            int totalSeats = numRolls * numColloms;
            double totalPrice = totalSeats * 1;

            if (movieType == "Premiere")
            {
                totalPrice = totalSeats * 12.00;
                Console.WriteLine($"{totalPrice:f2} Leva");
            }
            else if (movieType== "Normal")
            {
                totalPrice = totalSeats * 7.50;
                Console.WriteLine($"{totalPrice:f2} Leva");
            }
            else if (movieType == "Discount")
            {
                totalPrice = totalSeats * 5.00;
                Console.WriteLine($"{totalPrice:f2} Leva");
            }

        }
    }
}
