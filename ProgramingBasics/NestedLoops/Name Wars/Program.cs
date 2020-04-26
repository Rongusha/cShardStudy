using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int sum = 0;
            int maxSum = 0;
            string winer = "";

            while (name != "STOP")
            {
                
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    winer = name;
                    
                }
                sum = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winer} - {maxSum}!");
        }
    }
}
