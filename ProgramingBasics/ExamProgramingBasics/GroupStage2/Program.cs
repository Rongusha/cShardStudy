using System;

namespace GroupStage2
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int numPlays = int.Parse(Console.ReadLine());

            int scoreCount = 0;
            int receiveCount = 0;
            int pointsCount = 0;
            int machCount = 0;
            while (machCount < numPlays )
            {
                int scores = int.Parse(Console.ReadLine());
                scoreCount += scores;
                int received = int.Parse(Console.ReadLine());
                receiveCount += received;

                if (scores > received)
                {
                    pointsCount += 3;
                }
                else if (scores == received)
                {
                    pointsCount += 1;
                }
                machCount++;
            }
            if (scoreCount >= receiveCount)
            {
                Console.WriteLine($"{team} has finished the group phase with {pointsCount} points.");
                Console.WriteLine($"Goal difference: {scoreCount - receiveCount}.");
            }
            else
            {
                Console.WriteLine($"{team} has been eliminated from the group phase.");
                Console.WriteLine($"Goal difference: {scoreCount - receiveCount}.");
            }
        }
    }
}
