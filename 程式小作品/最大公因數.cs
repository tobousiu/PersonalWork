using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_Highfactor
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int n1, n2,g;
                String[] x = Console.ReadLine().Split(' ');
                if (x.Length !=2) break;
                n1 = int.Parse(x[0]);
                n2 = int.Parse(x[1]);
                if(n2>n1)
                {
                    (n1, n2) = (n2, n1);
                }

                while(n1%n2!=0)
                {
                    g = n1 % n2;
                    n1 = n2;
                    n2 = g;
                }
                Console.WriteLine($"{n2}");
            }
        }
    }
}
