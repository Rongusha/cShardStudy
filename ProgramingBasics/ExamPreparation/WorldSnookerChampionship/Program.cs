using System;

namespace WorldSnookerChampionship
{
    class Program
    {
        static void Main(string[] args)
        {
            string leaguePhase = Console.ReadLine();
            string typeOfTicket = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());

            double priceOfTicket = 0;
            double pictuirePrice = 40;

            if (leaguePhase == "Quarter final")
            {
                if (typeOfTicket == "Standard")
                {
                    priceOfTicket = 55.50;
                }
                else if (typeOfTicket == "Premium")
                {
                    priceOfTicket = 105.20;
                }
                else if (typeOfTicket == "VIP")
                {
                    priceOfTicket = 118.90;
                }
            }
            else if (leaguePhase == "Semi final")
            {
                if (typeOfTicket == "Standard")
                {
                    priceOfTicket = 75.88;
                }
                else if (typeOfTicket == "Premium")
                {
                    priceOfTicket = 125.22;
                }
                else if (typeOfTicket == "VIP")
                {
                    priceOfTicket = 300.40;
                }
            }
            else if (leaguePhase == "Final")
            {
                if (typeOfTicket == "Standard")
                {
                    priceOfTicket = 110.10;
                }
                else if (typeOfTicket == "Premium")
                {
                    priceOfTicket = 160.66;
                }
                else if (typeOfTicket == "VIP")
                {
                    priceOfTicket = 400;
                }
            }
            double gatherPrice = priceOfTicket * numberOfTickets;
            double totalPrice = 0;
            if (gatherPrice > 2500 && gatherPrice <= 4000)
            {
                gatherPrice = gatherPrice * 0.90;
            }
            else if (gatherPrice > 4000)
            {
                gatherPrice = gatherPrice * 0.75;
                pictuirePrice = 0;
            }
            else
            {
                gatherPrice = gatherPrice + 0;
            }
           
            if (picture == 'Y')
            {
                totalPrice = gatherPrice + (pictuirePrice * numberOfTickets);
            }
            else if (picture == 'N')
            {
                totalPrice = gatherPrice;
            }
          
            
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
