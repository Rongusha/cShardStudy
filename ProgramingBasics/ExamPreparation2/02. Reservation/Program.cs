using System;

namespace _02._Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
            int bookingDay = int.Parse(Console.ReadLine());
            int bookingMonth = int.Parse(Console.ReadLine());
            int arrivalDay = int.Parse(Console.ReadLine());
            int arrivalMonth = int.Parse(Console.ReadLine());
            int leavingDay = int.Parse(Console.ReadLine());
            int leavingMonth = int.Parse(Console.ReadLine());

            double roomPrice = 30;

            if (bookingDay <= (arrivalDay - 10))
            {
                roomPrice = 25;

            }
            if (bookingMonth < arrivalMonth)
            {
                roomPrice = 25 * 0.80;
            }

            int daysToStay = leavingDay - arrivalDay;
            double moneyNeed = daysToStay * roomPrice;

            Console.WriteLine($"Your stay from {arrivalDay}/{arrivalMonth} to {leavingDay}/{leavingMonth} will cost {moneyNeed:f2}");
        }
    }
}
