using System;

namespace TailoringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //rectangle and square matts 
            //rectangle to hand out 30cm of each side of the table
            //side of square = half of each table's lenght
            //1 square metre of rectangle matt = 7 usd
            //1 square metre of square matt = 9 usd
            //1 usd = 1.85 bgn
            //calculate the cost of each order in usd and bgn

            int numTables = int.Parse(Console.ReadLine());
            double lenghtTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

            double rectangleArea = (lenghtTable + 2 * 0.30) * (widthTable + 2 * 0.30);
            double rectangleOrder = rectangleArea * numTables;
            double rectanglePrice = rectangleOrder * 7;
           

            double squareArea = (lenghtTable / 2) * (lenghtTable / 2);
            double squareOrder = squareArea * numTables;
            double squarePrice = squareOrder * 9;
            double priceUsd = rectanglePrice + squarePrice;
            double priceBgn = (rectanglePrice + squarePrice) * 1.85;



            Console.WriteLine($"{priceUsd:f2} " + "USD");
            Console.WriteLine($"{priceBgn:f2} " + "BGN");





        }
    }
}
