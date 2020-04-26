using System;

namespace _02._Maiden_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            int numLoveNotes = int.Parse(Console.ReadLine());//0.60 for 1
            int numRoses = int.Parse(Console.ReadLine());//7.20 for 1
            int numKeyHolders = int.Parse(Console.ReadLine());//3.60 for 1
            int numMemes = int.Parse(Console.ReadLine());//18.20 for 1
            int numLyckies = int.Parse(Console.ReadLine());//22.00 for 1

            int itemSum = numLoveNotes + numRoses + numKeyHolders + numMemes + numLyckies;
            double sumPrice = (numLoveNotes * 0.60) + (numRoses * 7.20) + (numKeyHolders * 3.60) + (numMemes * 18.20) + (numLyckies * 22.00);

            if (itemSum > 24)
            {
                sumPrice = sumPrice * 0.65;
            }
            double sumAfterExpences = sumPrice * 0.90;

            if (sumAfterExpences >= moneyNeeded)
            {
                Console.WriteLine($"Yes! {sumAfterExpences - moneyNeeded:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {moneyNeeded - sumAfterExpences:f2} lv needed.");
            }
        }
    }
}
