using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_coin
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int p,a1,a2,a3;
                string x = Console.ReadLine();
                if (x == "") break;
                p = int.Parse(x);

                a1 = p / 10;
                a2 = (p-a1*10) / 5;
                a3 = (p - a1 * 10 - a2 * 5) / 1;

                Console.WriteLine("NT10=" + a1);
                Console.WriteLine("NT5=" + a2);
                Console.WriteLine("NT1=" + a3);
            }
        }
    }
}
