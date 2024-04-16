using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_bytetype_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    long ans1, g1, ans2, g2;
                    double line2 = 0;
                    double c = 0;
                    string line1="";
                    string line0="";
                    string n0 = "";
                    Console.WriteLine("==================================\n" +
                                      "請選擇方案:\n" +
                                      "A方案:10進位轉n進位\n" +
                                      "B方案:n進位轉10進位\n" +
                                      "==================================");
                    Console.Write("請輸入方案(A or B):");
                    string plan = Console.ReadLine();

                    switch (plan)
                    {
                        case "A":
                            Console.Write("\n您選擇的是A方案，\n" +
                                          "請輸入要進行轉換的進制(n=?):");
                            string n1 = Console.ReadLine();
                            long a = int.Parse(n1);
                            Console.Write("請輸入要進行轉換的數值:");
                            string x = Console.ReadLine();
                            long num1 = int.Parse(x);

                            if (num1 > 0)
                            {
                                while (num1 > 0)
                                {
                                    g1 = num1 % a;
                                    ans1 = num1 / a;
                                    num1 = ans1;
                                    line1 = Convert.ToString(g1)+line1;
                                }
                            }
                            else
                            {
                                num1 *= -1;
                                while (num1 > 0)
                                {
                                    g1 = num1 % a;
                                    ans1 = num1 / a;
                                    num1 = ans1;
                                    g1 = (a - 1) - g1;
                                    line0 = Convert.ToString(g1) + line0;
                                }
                                long nans1 = long.Parse(line0) + 1;
                                if (nans1 % 10 == a)
                                {
                                    while(nans1 % 10 == a)
                                    {
                                        ans1 = (nans1 / 10) + 1;
                                        nans1 = ans1;
                                        n0 += "0";
                                    }
                                    line1 = Convert.ToString(nans1)+n0;
                                }
                                else
                                {
                                    line1 = Convert.ToString(nans1);
                                    if (nans1 == 1)
                                    {
                                        line1 = Convert.ToString(nans1) + line0;
                                    }
                                }
                            }

                            Console.Write("\n轉換的數值為:");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(line1); 
                            Console.ForegroundColor = ConsoleColor.White;

                            break;

                        case "B":
                            Console.Write("\n您選擇的是B方案，\n" +
                                          "請輸入要進行轉換的進制(n=?):");
                            string n2 = Console.ReadLine();
                            double b = int.Parse(n2);
                            Console.Write("請輸入要進行轉換的數值:");
                            string y = Console.ReadLine();
                            long num2 = int.Parse(y);

                            while(num2>0)
                            {
                                ans2 = num2 / 10;
                                g2 = num2 % 10;
                                if (g2 >= b)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n該值無法進行轉換\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                                line2 = g2 * Math.Pow(b, c) + line2;
                                c++;
                                num2 = ans2;
                            }
                            Console.Write("\n轉換的數值為:");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(line2);
                            Console.ForegroundColor = ConsoleColor.White;

                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("您輸入的方案錯誤，請重新輸入。");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nAuto!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(100);
                }
            }
        
        }
    }
}
