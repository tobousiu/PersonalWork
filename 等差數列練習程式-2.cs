using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    checked 
                    {
                        Console.WriteLine(System.DateTime.Now);
                        double S;
                        double a1;
                        double n;
                        double d;
                        Random RD = new Random();
                        Console.Write("等差數列的和求S 請選擇方案A(自動) or 方案B(手動)");
                        string sth = Console.ReadLine();

                        switch(sth)
                        {
                            case "A":
                                Console.Write("a1=? n=? d=?");
                                string[] x = Console.ReadLine().Split(' ');

                                a1 = double.Parse(x[0]);
                                n = double.Parse(x[1]);
                                d = double.Parse(x[2]);
                                S = n * a1 + (n * (n - 1) * d / 2);

                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("S[和]=" + S);
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Black;

                                break;

                            case "B":
                                a1 = 100 * RD.NextDouble();
                                n  = 100 * RD.NextDouble();
                                d = 100 * RD.NextDouble();
                                Console.WriteLine("a1=" + Math.Round(a1, 0) + " n=" + Math.Round(n,0)+" d="+Math.Round(d,0));
                                S = n * a1 + (n * (n - 1) * d / 2);

                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.WriteLine("S[和]=" + Math.Round(S, 0));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Black;

                                break;

                            default:
                                return;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Random RD = new Random();
                    Console.WriteLine("again!\n");
                    System.Threading.Thread.Sleep(RD.Next(100, 1001));
                }
            }
        }
    }
}
