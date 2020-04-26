using System;

namespace WhileCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num >= 1 && num <= 100)
            {
                Console.WriteLine(num);
                
            }
            else
            {
                while (!(num >= 1 && num <= 100))
                {
                    num = int.Parse(Console.ReadLine());

                }
                Console.WriteLine(num);
            }

           
            
        }
    }
}
