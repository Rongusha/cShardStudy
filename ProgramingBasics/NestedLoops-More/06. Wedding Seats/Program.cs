using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorRows = int.Parse(Console.ReadLine());
            int numSeatsOddRow = int.Parse(Console.ReadLine());

            int numSeatsEvenRow = numSeatsOddRow + 2;
            int rowCount = numSeatsOddRow;
            int comboCounter = 0;

            for (char i = 'A'; i <= lastSector; i++)
            {

                for (int y = 1; y <= firstSectorRows; y++)
                {
                    char xToChar = 'a';
                    if (y%2==0)
                    {
                        rowCount = numSeatsEvenRow;
                    }
                    else
                    {
                        rowCount = numSeatsOddRow;
                    }
                    for (int x = 1; x <= rowCount; x++, xToChar++)
                    {
                        
                        Console.WriteLine($"{i}{y}{xToChar}");
                        comboCounter++;
                    }
                }
                firstSectorRows++;
            }
            Console.WriteLine(comboCounter);
        }
    }
}
