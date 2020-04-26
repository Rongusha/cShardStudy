using System;

namespace Scolarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double incomeLv = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minIncomeLv = double.Parse(Console.ReadLine());

            double socialScolarship = Math.Floor(minIncomeLv * 0.35);
            double gradeScolarship = Math.Floor(grade * 25);

            if ((incomeLv >= minIncomeLv && grade < 5.50) || (incomeLv <= minIncomeLv && grade < 4.50))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (incomeLv <= minIncomeLv && (grade < 5.50 && grade >= 4.50))
            {

                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else if ( grade >= 5.50 )
            {

                Console.WriteLine($"You get a scholarship for excellent results {gradeScolarship} BGN");
            }
           else if (incomeLv <= minIncomeLv && grade >= 5.50)
            {
                if (gradeScolarship > socialScolarship)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {gradeScolarship} BGN");

                }
                else if (socialScolarship > gradeScolarship)
                {
                    Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
                }

            }
           
        }
    }
}
