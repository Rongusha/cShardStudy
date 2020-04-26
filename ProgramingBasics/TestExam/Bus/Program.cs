using System;

namespace Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            int pplNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= stopNum; i++)
            {
                int pplOut = int.Parse(Console.ReadLine());
                int pplIn = int.Parse(Console.ReadLine());
                

                if (i%2!=0)
                {
                    pplIn = pplIn + 2;
                }
                else
                {
                    pplOut = pplOut + 2;
                }
                pplNum += pplIn;
                pplNum -= pplOut;
            }
            Console.WriteLine($"The final number of passengers is : {pplNum}");
        }
    }
}
