using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_CF
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double C, F;
                String x = Console.ReadLine();
                if (x == "") break;

                C = double.Parse(x);
                F = 9.0 / 5.0 * C + 32;
                if(F%1==0)
                {
                    Console.WriteLine(F+".0");
                }
                else
                {
                    Console.WriteLine(Math.Round(F, 1));
                }

            }
        }
    }
}
