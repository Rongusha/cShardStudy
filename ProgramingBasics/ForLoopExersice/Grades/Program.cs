using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());

            double topStudentsCount = 0; //grade >= 5
            double goodStudentsCount = 0; // grade  >= 4 && < 5
            double normalStudentsCount = 0; // grade >= 3 && < 4
            double failStudentsCount = 0; // grade < 3

            double topStudentsGrade = 0;
            double goodStudentsGrade = 0;
            double normalStudenGrade = 0;
            double failStudentsGrade = 0;
            double studentsTotalGrade = 0;

            for (int i = 0; i < numStudents; i++)
            {
                double studentGrade = double.Parse(Console.ReadLine());
                studentsTotalGrade += studentGrade;

                if (studentGrade < 3)
                {
                    failStudentsCount++;
                    failStudentsGrade += studentGrade;
                }
                else if (studentGrade >= 3 && studentGrade < 4)
                {
                    normalStudentsCount++;
                    normalStudenGrade += studentGrade;
                }
                else if (studentGrade >= 4 && studentGrade < 5)
                {
                    goodStudentsCount++;
                    goodStudentsGrade += studentGrade;
                }
                else if (studentGrade >= 5)
                {
                    topStudentsCount++;
                    topStudentsGrade += studentGrade;
                }
            }

            double averageGrade = studentsTotalGrade / numStudents;

            double topStudentsPercent = topStudentsCount / numStudents * 100;
            double goodStudentsPercent = goodStudentsCount / numStudents * 100;
            double normalStudentsPercent = normalStudentsCount / numStudents * 100;
            double failStudentsPercent = failStudentsCount / numStudents * 100;

            Console.WriteLine($"Top students: {topStudentsPercent:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodStudentsPercent:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {normalStudentsPercent:f2}%");
            Console.WriteLine($"Fail: {failStudentsPercent:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
