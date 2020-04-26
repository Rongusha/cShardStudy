using System;

namespace SleepingTom
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());
            int playWhenWork = 63;
            int playWhenOff = 127;
            // Tom need 30k minutes per anual to play
            int playNeeded = 30000;

            int playTimeDaysOff = daysOff * playWhenOff;
            int playTimeWorkDays = (365 - daysOff) * playWhenWork;
            int totalPlayMinutes = playTimeDaysOff + playTimeWorkDays;
            int difference = totalPlayMinutes - playNeeded;
            int hours = Math.Abs (difference / 60);
            int minutes = Math.Abs (difference % 60);


            if (totalPlayMinutes > playNeeded)
            {

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }


        }
    }
}
