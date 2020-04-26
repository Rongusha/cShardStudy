using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int steps = 0;
            
            int stepCounter = 0;

            while (command != "Going home")
            {
                steps += int.Parse(command);
               
                if (steps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    break;
                }
                command = Console.ReadLine();

               

            }
            if (command == "Going home")
            {
                command = Console.ReadLine();
                steps += int.Parse(command);
               
                if (steps < 10000)
                {
                    Console.WriteLine($"{10000 - steps} more steps to reach goal.");
                }
                else if (steps >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                }
            }
        }
    }
}
