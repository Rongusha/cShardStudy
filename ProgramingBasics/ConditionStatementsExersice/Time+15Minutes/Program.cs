using System;

namespace Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int convertToMinutes = hour * 60 + minute;
            int minutesPlusTime = convertToMinutes + 15;

            int newHour = minutesPlusTime / 60;
            int newMinutes = minutesPlusTime % 60;

            if (newHour >= 24)
            {
                newHour = newHour - 24;
            }
            if (newMinutes < 10)
            {
                Console.WriteLine($"{newHour}:0{newMinutes}");
            }
            else
            {
                Console.WriteLine($"{newHour}:{newMinutes}");
            }
        }
    }
}
