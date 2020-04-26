using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int examTotalMinutes = examHour * 60 + examMin;
            int arrivalTotalMinutes = arrivalHour * 60 + arrivalMin;
            int timeDifference = examTotalMinutes - arrivalTotalMinutes;

            if (timeDifference < 0)
            {
                Console.WriteLine("late");
                int timeDifferenceAbs = Math.Abs(timeDifference);
                if (timeDifferenceAbs < 60)
                {
                    Console.WriteLine($"{timeDifferenceAbs}minutes after the start");
                }
                else
                {
                    int hour = timeDifferenceAbs / 60;
                    int minutes = timeDifferenceAbs % 60;

                    Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
                }
            }
            else if (timeDifference > 30)
            {
                Console.WriteLine("Early");
                if (timeDifference < 60)
                {
                    Console.WriteLine($"{timeDifference}minutes before the start");
                }
                else
                {
                    int hour = timeDifference / 60;
                    int minutes = timeDifference % 60;

                    Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("On time");
                if (timeDifference != 0)
                {
                    Console.WriteLine($"{timeDifference}minutes before the start");
                }
                
            }
        }
    }
}
