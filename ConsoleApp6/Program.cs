using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (double x = -0; x <= 5; x += 0.25)
                {
                    double y = 0;
                    if (x <= 2)
                    {
                        double S = 0;
                        for (int k = 1; k <= 5; k++)
                        {
                            S += k * x * x - x + k;
                        }
                        y = S;
                    }
                    else
                    {
                        y = Math.Atan(x);
                    }
                    Console.WriteLine("|{0,13:F2}|{1,14:F2}|", x, y);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
