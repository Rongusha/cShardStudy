using System;

namespace Mooving
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int boxes = 0;

            int totalSpace = weight * lenght * height;

            while (command != "Done")
            {
                boxes += int.Parse(command);
                if (boxes > totalSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxes - totalSpace} Cubic meters more.");
                    break;
                }
                command = Console.ReadLine();

                

            }
            if (totalSpace >= boxes)
            {
                Console.WriteLine($"{totalSpace - boxes} Cubic meters left.");
            }
        }
    }
}
