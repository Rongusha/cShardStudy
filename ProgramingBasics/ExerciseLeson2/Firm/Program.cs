using System;

namespace Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursToCompleteProject = int.Parse(Console.ReadLine());
            double daysForProject = int.Parse(Console.ReadLine());
            int numOvertimeWorkers = int.Parse(Console.ReadLine());

            double timeLoss = daysForProject * 0.10;
            double daysGivenForProject = daysForProject - timeLoss;
            double hoursGivenForProject = (daysGivenForProject * 8);
            double overtimeHours = numOvertimeWorkers * (daysForProject * 2);
            double totalHoursGiven = Math.Floor(hoursGivenForProject + overtimeHours);

            if (totalHoursGiven >= hoursToCompleteProject)
            {
                double difference = totalHoursGiven - hoursToCompleteProject;
                Console.WriteLine($"Yes!{difference} hours left.");


            }
            else
            {
                double difference = hoursToCompleteProject - totalHoursGiven;
                Console.WriteLine($"Not enough time!{difference} hours needed.");
            }


        }
    }
}
