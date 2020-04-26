using System;

namespace Salary2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            int loopCount = 0;

            while (salary > 0)
            {
                string website = Console.ReadLine();
                loopCount++;

              
                if (website == "Facebook")
                {
                    salary -= 150;
                }
                if (website == "Instagram")
                {
                    salary -= 100;
                }
                if (website == "Reddit")
                {
                    salary -= 50;
                }

                if (loopCount == count)
                {
                    break;
                }


            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($"{salary}");
            }
            
        }
    }
}
