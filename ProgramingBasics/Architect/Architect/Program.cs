using System;

namespace Architect
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = (Console.ReadLine());
            int numProjects = int.Parse(Console.ReadLine());

            int totalTime = numProjects * 3;

            Console.WriteLine($"The architect {archName} will need {totalTime} hours to complete {numProjects} project/s.");

        }
    }
}
