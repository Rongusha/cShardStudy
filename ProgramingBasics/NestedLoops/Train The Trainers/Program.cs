using System;

namespace Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numTeachers = int.Parse(Console.ReadLine());

            double totalAverage = 0;
            double topicCounter = 0;

            while (true)
            {
                string topic = Console.ReadLine();

                if (topic == "Finish")
                {
                    break;
                }

                topicCounter++;
                double gradeSum = 0;
                for (int i  = 0; i < numTeachers; i++)
                {
                     gradeSum += double.Parse(Console.ReadLine());
                }
                double averageGrade = gradeSum / numTeachers;
                Console.WriteLine($"{topic} - {averageGrade:f2}.");
                totalAverage += averageGrade;
            }
            Console.WriteLine($"Student's final assessment is {totalAverage / topicCounter:f2}.");
        }
    }
}
