using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string feedback = Console.ReadLine();

            int numNights = numDays - 1;

            int roomForOnePrice = 18;
            int apartmentPrice = 25;
            int presidentPrice = 35;

            double sumBeforeDiscount = 0;

            if (numDays < 10)
            {
                if (roomType == "room for one person")
                {
                    sumBeforeDiscount = numNights * roomForOnePrice;
                }
                else if (roomType == "apartment")
                {
                    sumBeforeDiscount = (numNights * apartmentPrice) * 0.70;


                }
                else if (roomType == "president apartment")
                {
                    sumBeforeDiscount = (numNights * presidentPrice) * 0.90;
                }
            }
            else if (numDays >= 10 && numDays <= 15)
            {
                if (roomType == "room for one person")
                {
                    sumBeforeDiscount = numNights * roomForOnePrice;
                }
                else if (roomType == "apartment")
                {
                    sumBeforeDiscount = (numNights * apartmentPrice) * 0.65;
                }
                else if (roomType == "president apartment")
                {
                    sumBeforeDiscount = (numNights * presidentPrice) * 0.85;
                }
            }
            else if (numDays > 15)
            {
                if (roomType == "room for one person")
                {
                    sumBeforeDiscount = numNights * roomForOnePrice;
                }
                else if (roomType == "apartment")
                {
                    sumBeforeDiscount = (numNights * apartmentPrice) * 0.50;
                }
                else if (roomType == "president apartment")
                {
                    sumBeforeDiscount = (numNights * presidentPrice) * 0.80;
                }


            }

            double sumAfterDiscount = 0;


            if (feedback == "positive")
            {
                sumAfterDiscount = sumBeforeDiscount * 1.25;
            }
            else if (feedback == "negative")
            {
                sumAfterDiscount = sumBeforeDiscount * 0.90;
            }

            Console.WriteLine($"{sumAfterDiscount:f2}");
        }
    }
}
