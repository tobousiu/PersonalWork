using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Random rd = new Random();
                    int N,i,ans0,k;
                    int d = 0;
                    int ans1 = 0;
                    int a = 0;
                    Console.WriteLine("=================================\n"
                                       + "請用N個以亂數產生1~1000的整數，\n"
                                       + "並求質數的相關答案，\n"
                                       + "===============================");
                    Console.Write("N=");
                    string x = Console.ReadLine();
                    N = int.Parse(x);

                    checked
                    {
                        for (i = 1; i <= N; i++)
                        {
                            ans0 = rd.Next(1, 1001);

                            for (k = 1; k <= ans0; k++)
                            {
                                if (ans0 % k == 0)
                                {
                                    d += 1;
                                }
                            }

                            if (d == 2)
                            {
                                Console.WriteLine(ans0 + "為質數");
                                ans1 += ans0;
                                a++;
                            }
                            else
                            {
                                Console.WriteLine(ans0 + "不為質數");
                            }
                            d = 0;
                        }
                        Console.Write("質數共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之值");

                    }
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Random rd = new Random();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nAuto!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(rd.Next(100, 1001));
                }
            }
        }
    }
}
