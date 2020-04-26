using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int[] firstArray = new int[numbers];
            int[] secondArray = new int[numbers];

            for (int i = 0; i < firstArray.Length; i++)
            {
                int[] newArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i%2==0)
                {
                    firstArray[i] = newArray[0];
                    secondArray[i] = newArray[1];
                }
                else
                {
                    firstArray[i] = newArray[1];
                    secondArray[i] = newArray[0];
                }
              
            }

            foreach (var index in firstArray)
            {
                Console.Write(index + " ");
            }

            Console.WriteLine();

            foreach (var index2 in secondArray)
            {
                Console.Write(index2 + " ");
            }
        }
    }
}
