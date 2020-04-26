using System;

namespace DishWasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int bottles = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int dishes = 0;
            int pans = 0;
            int inputCounter = 0;

            int vero = bottles * 750;
            int dishesVero = 0;
            int pansVero = 0;
            int veroNeeded = dishesVero + pansVero;



            while (command != "End")
            {
                
                inputCounter++;
               

                if (inputCounter == 3)
                {
                    pans += int.Parse(command);
                    inputCounter = 0;
                     pansVero = pans * 15;
                    
                }
                else
                {
                    dishes += int.Parse(command);
                    dishesVero = dishes * 5;
                    
                }
                veroNeeded = dishesVero + pansVero;
                if (vero < veroNeeded)
                {
                    Console.WriteLine($"Not enough detergent, {veroNeeded - vero} ml. more necessary!");
                    break;
                }

                command = Console.ReadLine();
            }
            if (vero >= veroNeeded)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pans} pots were washed.");
                Console.WriteLine($"Leftover detergent {vero - veroNeeded} ml.");
            }
           
        }
    }
}
