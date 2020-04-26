using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int treatedPatiens = 0;
            int untreatedPatiens = 0;
            int numDoctors = 7;

            for (int i = 1; i <= numDays; i++)
            {
                if (i % 3 == 0)
                {
                    if (treatedPatiens < untreatedPatiens)
                    {
                        numDoctors++;
                    }
                }
                int patiens = int.Parse(Console.ReadLine());

                if (patiens < numDoctors)
                {
                    treatedPatiens += patiens;
                }
                else if (patiens == numDoctors)
                {
                    treatedPatiens += numDoctors;
                }
                else if (patiens > numDoctors)
                {
                    treatedPatiens += numDoctors;
                    untreatedPatiens += (patiens - numDoctors);

                }


            }

            Console.WriteLine($"Treated patients: {treatedPatiens}.");
            Console.WriteLine($"Untreated patients: {untreatedPatiens}.");
        }
    }
}
