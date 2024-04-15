using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_XmultiplyX
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string x = Console.ReadLine();
                if (x == "") break;
                int n = int.Parse(x);

                for(int i=1;i<=n;i++)
                {
                    Console.WriteLine($"{i}*{i}={i * i}");
                }
            }
        }
    }
}
