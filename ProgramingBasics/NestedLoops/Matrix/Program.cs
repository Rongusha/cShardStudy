using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            for (int ff = a; ff <= b; ff++)
            {
                for (int fs = a; fs <= b; fs++)
                {
                    for (int sf = c; sf <= d; sf++)
                    {
                        for (int ss = c; ss <= d; ss++)
                        {
                            if (((ff + ss) == (fs + sf)) && ((ff != fs) && (sf != ss)))
                            {
                                Console.WriteLine($"{ff}{fs}");
                                Console.WriteLine($"{sf}{ss}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
            }
        }

    }
}
