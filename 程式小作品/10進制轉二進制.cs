using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_10b2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int b;
                string n = Console.ReadLine();
                if (n == "") break;
                int a = int.Parse(n);

                if (a > 127 || a < -128)
                {
                    break;
                }

                if (a > 0)
                {
                    string s1 = string.Format("{0:00000000}", int.Parse(Convert.ToString(a, 2)));
                    Console.WriteLine(s1);
                }
                else
                {
                    b = (a * -1) + 1;
                    //string s2 = string.Format("{0:00000000}", ~int.Parse(Convert.ToString(b, 2)));
                    Console.WriteLine(int.Parse(Convert.ToString(b, 2)));
                }


            }
        }
    }
}
