using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long i;
                long ans = 1;
                string x = Console.ReadLine();
                if (x == "") break;
                long n = long.Parse(x);


               
                for (i = 1; i <= n; i++)
                {
                    ans *= i;
                }
                

                Console.WriteLine(ans);
            }
        }
    }
}
