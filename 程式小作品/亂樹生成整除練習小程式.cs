using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_ta1plus
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Random rd = new Random();
                    int N, K, L, rdl, i;
                    int ans0 = 0;
                    int ans1 = 0;
                    int ans2 = 0;
                    int ans3 = 0;
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    int d = 0;
                    Console.WriteLine("=================================\n" +
                                      "請輸入N個以亂數產生的整數，\n" +
                                      "並求能被K和L整除的相對答案。\n" +
                                      "=================================");
                    Console.Write("N=");
                    string x = Console.ReadLine();
                    N = int.Parse(x);
                    Console.Write("K=");
                    string y = Console.ReadLine();
                    K = int.Parse(y);
                    Console.Write("L=");
                    string z = Console.ReadLine();
                    L = int.Parse(z);

                    checked
                    {
                        for (i = 1; i <= N; i++)
                        {
                            rdl = rd.Next(0, 1001);

                            if((rdl % L == 0)&& (rdl % K == 0))
                            {
                                Console.Write(i + ".     " + rdl + "     ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("＊");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("＊");
                                Console.ForegroundColor = ConsoleColor.White;
                                ans3 += rdl;
                                d++;
                            }
                            else if (rdl % K == 0)
                            {
                                Console.Write(i + ".     " + rdl + "     ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("＊");
                                Console.ForegroundColor = ConsoleColor.White;
                                ans0 += rdl;
                                a++;
                            }
                            else if (rdl % L == 0)
                            {
                                Console.Write(i + ".     " + rdl + "     ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("＊");
                                Console.ForegroundColor = ConsoleColor.White;
                                ans1 += rdl;
                                b++;
                            }
                            else
                            {
                                Console.WriteLine(i + ".     " + rdl + "     ");
                                ans2 += rdl;
                                c++;
                            }

                        }

                        Console.Write("能被K和L整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(d);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans3);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值\n");

                        Console.Write("能被K整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(a+d);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans0+ans3);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值");

                        Console.Write("只能被K整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(a);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值\n");

                        Console.Write("能被L整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(b+d);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans1+ans3);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值");

                        Console.Write("只能被L整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(b);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值\n");

                        Console.Write("其餘共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(c);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值");
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
