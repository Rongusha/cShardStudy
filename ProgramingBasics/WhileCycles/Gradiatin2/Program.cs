using System;

namespace Gradiatin2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = 1;
            int failCount = 1;
            double grade = 0;
            double average = 0;

            while (count <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                count++;
                average += grade;

                if (grade < 4)
                {
                    grade = double.Parse(Console.ReadLine());
                    failCount++;
                    if (failCount > 1)
                    {
                        Console.WriteLine($"{name} has been excluded at {--count} grade");
                        return;
                    }
                }
            }
            Console.WriteLine($"{name} graduated. Average grade: {average / 12:f2}");
        }
    }
}
