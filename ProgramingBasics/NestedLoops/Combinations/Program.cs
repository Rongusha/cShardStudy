using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int comboCount = 0;

            for (int firstNum = 0; firstNum <= number; firstNum++)
            {
                for (int secondNum = 0; secondNum <= number; secondNum++)
                {
                    for (int thirdNum = 0; thirdNum <= number; thirdNum++)
                    {
                        if (firstNum+secondNum+thirdNum == number)
                        {
                            comboCount++;
                        }
                    }
                }
            }
            Console.WriteLine(comboCount);
        }
    }
}
