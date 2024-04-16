using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_primeYorN
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string x = Console.ReadLine();
                if (x == "") break;
                long n = long.Parse(x);
                if (n >= Math.Pow(2, 31) - 1) break;

                int con = 0;
                for(long i=1;i<=n;i++)
                {
                    if(n%i==0)
                    {
                        con++;
                    }
                }
                if(con==2)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
