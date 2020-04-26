using System;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double metresToDo = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double timeNeededToFinish = metresToDo * timeInSeconds;
            double metersSlowed = Math.Floor( metresToDo / 15);
            double timeSlowed =  (metersSlowed * 12.5);
            double totalTimeNeeded =  timeNeededToFinish + timeSlowed;

            if (record > totalTimeNeeded)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTimeNeeded:f2} seconds.");
            }
            else
            {
                double timeDifference = totalTimeNeeded - record;
                Console.WriteLine($"No, he failed! He was {timeDifference:f2} seconds slower.");
            }
        }
    }
}
