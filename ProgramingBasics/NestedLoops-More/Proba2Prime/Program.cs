using System;

namespace Proba2Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;

            num1 = int.Parse(Console.ReadLine());//starting number
            num2 = int.Parse(Console.ReadLine());//ending number

            for ( num3 = num1; num3 <= num2; num3++)
            {
                num4 = 0;//filter for non-Prime numbers(moje i bool izdraz)
                for (int i = 2; i <=num3/2 ; i++)// where the magic happens :D
                {
                    if (num3%i==0)//i zapochva ot 2 znachi ako chetno vliza, vkliuchva filtyra i izliza.
                    {
                        num4++;
                        break;
                    }
                }
                if (num4 ==0 && num3!=1)// ako ima filtyr ne vliza
                {
                    Console.WriteLine(num3);//prime numebr!
                }
            }
            

        }
    }
}
