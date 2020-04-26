using System;

namespace Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
           

            double moneySaved = 0;

            while (destination != "End")
            {
                double budget = double.Parse(Console.ReadLine());
                while (moneySaved < budget)
                {
                    moneySaved += double.Parse(Console.ReadLine());

                    if (moneySaved >= budget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        moneySaved = 0;
                        break;

                    }
                }

                destination = Console.ReadLine();
               
            }

        }
    }
}
