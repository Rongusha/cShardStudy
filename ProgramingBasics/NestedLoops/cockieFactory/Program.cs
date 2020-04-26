using System;

namespace cockieFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCockies = int.Parse(Console.ReadLine());



            string product = "";
            bool flour = false;
            bool eggs = false;
            bool sugar = false;
            bool isBake = false;

            for (int i = 1; i <= numCockies; i++)
            {

                while (!isBake)
                {
                    product = Console.ReadLine();
                    switch (product)
                    {
                        case "flour": flour = true; break;
                        case "eggs": eggs = true; break;
                        case "sugar": sugar = true; break;
                        case "Bake!":

                            if (eggs && flour && sugar)
                            {
                                isBake = true;
                                Console.WriteLine($"Baking batch number {i}...");
                                flour = false;
                                eggs = false;
                                sugar = false;
                            }
                            else
                            {
                                Console.WriteLine("The batter should contain flour, eggs and sugar!");
                            }

                            break;
                    }



                }
                isBake = false;



            }
        }
    }
}
