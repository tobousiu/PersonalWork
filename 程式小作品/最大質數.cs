using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_maxprime
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string x = Console.ReadLine();
                if (x == "") break;
                int n = int.Parse(x);

                int con = 0;
                for (int i = n; i > 0; i--)
                {
                    for(int j=1;j<=i;j++)
                    {
                        if(i%j==0)
                        {
                            con++;
                        }
                    }
                    if(con==2 && i!=n)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    con = 0;
                }
            }
        }
    }
}
