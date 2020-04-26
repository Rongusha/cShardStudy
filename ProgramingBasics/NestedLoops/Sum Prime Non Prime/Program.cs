using System;

namespace Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            string command = num;
            int primeSum = 0;
            int notPrimeSum = 0;
           

            while (command!="stop")
            {
               
                int numToNumber = int.Parse(num);

                if (numToNumber < 0)
                {
                    Console.WriteLine("Number is negative.");

                }
                else if (numToNumber == 2 || numToNumber == 3 || numToNumber % 2 != 0 && numToNumber % 3 != 0)
                {
                    primeSum += numToNumber;
                }
                else
                {
                    notPrimeSum += numToNumber;
                }

               
                num = Console.ReadLine();
                command = num;

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");
        }
    }
}
