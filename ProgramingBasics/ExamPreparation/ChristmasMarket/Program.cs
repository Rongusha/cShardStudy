using System;

namespace ChristmasMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetMoney = double.Parse(Console.ReadLine());
            int fantasyBooks = int.Parse(Console.ReadLine());
            int horrorBooks = int.Parse(Console.ReadLine());
            int romanticBooks = int.Parse(Console.ReadLine());

            double fantasyPrice = 14.90;
            double horrorPrice = 9.80;
            double romanticPrice = 4.30;

            double moneyFromFantasy = fantasyPrice * fantasyBooks;
            double moneyFromHorror = horrorPrice * horrorBooks;
            double moneyFromRomantic = romanticPrice * romanticBooks;

            double moneyBeforeTax = moneyFromFantasy + moneyFromHorror + moneyFromRomantic;
            double moneyAfterTax = moneyBeforeTax * 0.80;

            if (moneyAfterTax >= targetMoney)
            {
                double difference = moneyAfterTax - targetMoney;
                double bonuses =Math.Floor (difference * 0.10);
                double moneyAfterBonus = difference - bonuses;
                double donatedMoney = targetMoney + moneyAfterBonus;
                Console.WriteLine($"{donatedMoney:f2} leva donated.");
                Console.WriteLine($"Sellers will receive {bonuses} leva.");
            }
            else
            {
                Console.WriteLine($"{targetMoney-moneyAfterTax:f2} money needed.");
            }
        }
    }
}
