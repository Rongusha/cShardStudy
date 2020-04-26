using System;

namespace Logistic
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOFLoads = int.Parse(Console.ReadLine());

            int type1Count = 0;  // <=3 tons = 200lv/t
            int type2Count = 0; // between 4 and 11 tons = 175lv/t
            int type3Count = 0;  // >= 12 tons = 120lv/t
            double type1Weight = 0;
            double type2Weight = 0;
            double type3Weight = 0;


            int totalLoadWeight = 0;

            for (int i = 0; i < numOFLoads; i++)
            {
                int loadWeight = int.Parse(Console.ReadLine());
                totalLoadWeight += loadWeight;

                if (loadWeight <= 3)
                {
                    type1Count++;
                    type1Weight += loadWeight;
                }
                else if (loadWeight >= 4 && loadWeight <= 11)
                {
                    type2Count++;
                    type2Weight += loadWeight;
                }
                else if (loadWeight >= 12)
                {
                    type3Count++;
                    type3Weight += loadWeight;
                }
            }

            double type1Money = type1Weight * 200;
            double type2Money = type2Weight * 175;
            double type3Money = type3Weight * 120;
            double totalMoney = type1Money + type2Money + type3Money;

            double averagePrice = totalMoney / totalLoadWeight;

            double type1Percent = (type1Weight / totalLoadWeight) * 100;
            double type2Percent = (type2Weight / totalLoadWeight) * 100;
            double type3Percent = (type3Weight / totalLoadWeight) * 100;

            Console.WriteLine($"{averagePrice:f2}");
            Console.WriteLine($"{type1Percent:f2}%");
            Console.WriteLine($"{type2Percent:f2}%");
            Console.WriteLine($"{type3Percent:f2}%");
            
        }
    }
}
