using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_trapezoid
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            double a, b, h, ans;
            string[] x = Console.ReadLine().Split(' ');
            if (x.Length != 3 ) break;
                a = double.Parse(x[0]);
                b = double.Parse(x[1]);
                h = double.Parse(x[2]);

                ans = (a + b) * h / 2;
                if (ans % 2 == 0)
                {
                    Console.WriteLine("Trapezoid area:" + ans + ".0");
                }
                else
                {
                    Console.WriteLine("Trapezoid area:" + ans );
                }
            }

        }
    }
}
