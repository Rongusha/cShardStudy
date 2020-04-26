using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = 1;
            double grade = 0;
            double average = 0;

            while (count <= 12)
            {
                grade = double.Parse(Console.ReadLine());

                if (grade >= 4.00)
                {
                    average += grade;
                    count++;
                    
                }
                
            }
            
            Console.WriteLine($"{name} graduated. Average grade: {average / 12:f2}");
        }
    }
}
