using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_sec
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long d, h, m, s0, s1;
                string x = Console.ReadLine();
                if (x == "") break;

                s0 = long.Parse(x);
                d = s0 / (60 * 60 * 24);
                h = (s0 - (d * 60 * 60 * 24)) / (60 * 60);
                m = (s0 - (d * 60 * 60 * 24) - (h * 60 * 60)) / 60;
                s1 = s0 - (d * 60 * 60 * 24) - (h * 60 * 60) - (m * 60);
                Console.WriteLine(d +" " + "days");
                Console.WriteLine(h +" " + "hours");
                Console.WriteLine(m +" " + "minutes");
                Console.WriteLine(s1 +" " + "seconds");

            }
        }
    }
}
