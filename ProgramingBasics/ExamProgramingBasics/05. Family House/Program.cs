using System;

namespace _05._Family_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double electricityBill = 0;
            double waterBill = 20 ;
            double totalWaterBill = waterBill * months;
            double internetBill = 15 ;
            double totalInternetBill = internetBill * months;
            double otherBill = 0;//20% from all bills sum
            double totalOtherBill = 0;
            double allBills = 0;
            
            for (int i = 1; i <= months; i++)
            {
                double electricBill = double.Parse(Console.ReadLine());
                electricityBill += electricBill;
                allBills = ((electricBill + waterBill) + internetBill);
                otherBill = allBills + (allBills * 0.20);
                totalOtherBill += otherBill;


            }

            double totalAllBills = totalWaterBill + totalInternetBill + totalOtherBill + electricityBill;
            double average = totalAllBills / months;

            Console.WriteLine($"Electricity: {electricityBill:f2} lv");
            Console.WriteLine($"Water: {totalWaterBill:f2} lv");
            Console.WriteLine($"Internet: {totalInternetBill:f2} lv");
            Console.WriteLine($"Other: {totalOtherBill:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");
        }
    }
}
