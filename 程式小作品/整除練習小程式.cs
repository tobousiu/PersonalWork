using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_ta1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                
                int N, K, i;
                Random rd = new Random();
                int d=0;
                try
                {
                    Console.WriteLine("===========================\n"+
                                      "亂數產生N個界於0~500的數字，\n"+
                                       "並計算有幾個能被K整除。\n"+
                                       "===========================");
                    Console.Write("N=");
                    string x = Console.ReadLine();
                    N = int.Parse(x);
                    Console.Write("K=");
                    string y = Console.ReadLine();
                    K = int.Parse(y);

                    checked
                    {
                        for (i = 1; i <= N; i++)
                        {
                            int ans = rd.Next(0, 501);
                            if (ans % K == 0)
                            {

                                Console.Write(i+".     "+ ans +"     ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("*");
                                Console.ForegroundColor = ConsoleColor.White;
                                d++;
                            }
                            else
                            {
                                Console.WriteLine(i + ".     " + ans + "     ");
                            }
                        }

                        Console.Write("能被" + K + "整除的有");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(d);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個\n");

                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nAuto!\n");
                    System.Threading.Thread.Sleep(rd.Next(100, 1001));
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
