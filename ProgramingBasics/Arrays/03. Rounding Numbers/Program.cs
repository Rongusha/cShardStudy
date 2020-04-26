using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {


           

            string[] arrayToReverce = Console.ReadLine().Split();//Reading input of strings and create an array

            for (int i = 0; i < arrayToReverce.Length; i++)//Creating a for loop to reach each element of the array (if we want rach to half of the elements can do "arrayToReverce.Lenght/2")
            {
                Console.WriteLine(arrayToReverce[arrayToReverce.Length - i - 1]);//Reverce the array (print it from back to front)
            }

            // string values = Console.ReadLine();
            //string[] selectedValues = new string[] {"1","2","3","4" };//Creating an array of strings with numbers in it
            //double[] toArray = new double[selectedValues.Length];//Creating new array of double/int thats is same size as the string array

            //for (int i = 0; i < selectedValues.Length; i++)//Creating a for loop to go around the array 
            //{
            //    toArray[i] = double.Parse(selectedValues[i]);//Read each box of the string array as number and save it to same position box in double/int array
            //}

            //for (int j = 0; j < selectedValues.Length; j++)
            //{
            //    roundedNums[j] = (int)Math.Round(toArray[j], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{toArray[j]} => {roundedNums[j]}");
            //}

            //double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();//Creating a double/int array, asking for string inputs, spliting the inputs to elements of an array, select and parce it to int/double and save them to the current int/double array
            //int[] roundedNumbers = new int[numbers.Length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    roundedNumbers[i] =(int) Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{numbers[i]} => {roundedNumbers[i]}");
            //}

        }
    }
}
