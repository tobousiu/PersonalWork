using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_PrimeGL_ta
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    int LCM;
                    int conP = 0, confi=1 ;
                    int g=0;
                    string line1 = "";
                    Console.WriteLine("======================================\n"+
                                      "功能選項：\n"+
                                      "Ａ：找出Ｘ個大於Ｙ的質數\n"+
                                      "Ｂ：找出Ｘ及Ｙ的所有公因數＆最小公倍數\n"+
                                      "=======================================");
                    Console.Write("功能？ Ｘ？ Ｙ？＝");
                    string[] x = Console.ReadLine().Split(' ');
                    if (x.Length != 3) continue;
                    int n1 = int.Parse(x[1]);
                    int n2 = int.Parse(x[2]);
                    Console.WriteLine();


                    switch (x[0])
                    {
                        case "A":


                            while (confi<=n1)
                            {
                                int i1 = 1;
                                while (i1<=n2)
                                {
                                    if(n2%i1==0)
                                    {
                                        conP++;
                                    }
                                    i1++;
                                }
                                if(conP==2)
                                {
                                    Console.WriteLine($"{confi}.     {n2}");
                                    confi++;
                                }
                                conP = 0;
                                n2++;
                            }

                            break;

                        case "B":
                            int sa;
                            if(n1>n2)
                            {
                                sa = n1;
                                n1 = n2;
                                n2 = sa;
                            }

                            int i2 = 1;
                            while(i2<=n1)
                            {
                                if(n1%i2==0 && n2%i2==0)
                                {
                                    line1 += $"{i2} ";
                                }
                                i2++;
                            }
                            int num1 = n2;
                            int num2 = n1;

                            while(num2!=0)
                            {
                                g = num1 % num2;
                                num1 = num2;
                                num2 = g;
                            }

                            LCM = n1 * n2 / num1;

                            Console.WriteLine($"所有公因數:{line1}");
                            Console.WriteLine($"最小公倍數:{LCM}({n1}*{LCM/n1}、{n2}*{LCM/n2})");

                            break;

                        default:
                            continue;
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{ex.Message}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nAuto!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(1001);
                }
            }
        }
    }
}
