using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_meet
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                double s, t, k;
                string x = Console.ReadLine();
                if (x == "") break;

                k = double.Parse(x);
                s = (30 * 2.54)/100;
                t = k / (1 - s);

                if (t % 1 >= 0.5)
                {
                    Console.WriteLine(Math.Round(t, 0));

                }
                else
                {
                    Console.WriteLine(Math.Round(t, 0)+1);

                }

            }
        }
    }
}
