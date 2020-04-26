using System;

namespace Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combocount = 0;


            for (int i = firstNum; i <= secondNum; i++)
            {
                for (int x = firstNum; x <= secondNum; x++)
                {
                    combocount++;
                    if (i+x == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combocount} ({i} + {x} = {magicNum})");
                        return;
                    }
                    
                }
                
            }
            Console.WriteLine($"{combocount} combinations - neither equals {magicNum}");
        }
    }
}
