using System;

namespace SwimingPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int litresForPool = int.Parse(Console.ReadLine());
            int tube1 = int.Parse(Console.ReadLine());
            int tube2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double litresFromTube1 = tube1 * hours;
            double litresFromTube2 = tube2 * hours;
            double totalLitresInPool = litresFromTube1 + litresFromTube2;

            if (litresForPool >= totalLitresInPool)
            {
                double persentageFromTube1 = (litresFromTube1 / totalLitresInPool) * 100;
                double persentageFromTube2 = (litresFromTube2 / totalLitresInPool) * 100;
                double persentageInPool =(totalLitresInPool / litresForPool) * 100;
                Console.WriteLine($"The pool is {persentageInPool:f2}% full. Pipe 1: {persentageFromTube1:f2}%. Pipe 2: {persentageFromTube2:f2}%.");
            }
            else
            {
                double overflow = totalLitresInPool - litresForPool;
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {overflow:f2} liters.");
            }
            
        }
    }
}
