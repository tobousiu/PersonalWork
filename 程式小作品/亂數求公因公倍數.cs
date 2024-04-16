using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_PrimeGCDLCM
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            while (true)
            {
                try
                {
                    int conn = 1;
                    int num;
                    int conFa1 = 0, conFa2 = 0, conFa3 = 0, conoth=0;
                    int sumFa1 = 0, sumFa2 = 0, sumFa3 = 0, sumoth=0;
                    int conFa = 0, sumFa = 0;
                    int conPi = 0, sumPi = 0;
                    string line = "";
                    Console.WriteLine("============================================\n" +
                                      "請輸入n個以亂數產生的1~1000的整數，\n" +
                                      "並輸入三個因數(分別Fa1,Fa2,Fa3)，\n" +
                                      "產生結果為該相關倍數個數`總和及質數的輸出。\n" +
                                      "(字體變綠代表該樹為質數，紅＊為Fa1的倍數，\n" +
                                      "藍＊為Fa2的倍數，黃＊為Fa3的倍數)\n" +
                                      "============================================");
                    Console.Write("n=");
                    string sx0 = Console.ReadLine();
                    if (sx0 == "") continue;

                    Console.Write("因數1(Fa1)=");
                    string sx1 = Console.ReadLine();
                    if (sx1 == "") continue;

                    Console.Write("因數2(Fa2)=");
                    string sx2 = Console.ReadLine();
                    if (sx2 == "") continue;

                    Console.Write("因數3(Fa3)=");
                    string sx3 = Console.ReadLine();
                    if (sx3 == "") continue;
                    Console.WriteLine();

                    int n = int.Parse(sx0);
                    int Fa1 = int.Parse(sx1);
                    int Fa2 = int.Parse(sx2);
                    int Fa3 = int.Parse(sx3);
                    if (Fa1 == Fa2 || Fa2 == Fa3 || Fa3 == Fa1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("因數重複，請重新輸入!");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    checked
                    {
                        while (conn <= n)
                        {
                            num = rd.Next(1, 1001);
                            Console.Write($"{conn}. ");
                            if (Prime(num))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write($"{num} ");
                                if (Math.Abs(Fa1) == 1 || Math.Abs(Fa1) == num)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("＊");
                                    conFa1++;
                                    sumFa1 += num;
                                    conPi++;
                                    sumPi += num;
                                }
                                else if (Math.Abs(Fa2) == 1 || Math.Abs(Fa2) == num)
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("＊");
                                    conFa2++;
                                    sumFa2 += num;
                                    conPi++;
                                    sumPi += num;
                                }
                                else if (Math.Abs(Fa3) == 1 || Math.Abs(Fa3) == num)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("＊");
                                    conFa3++;
                                    sumFa3 += num;
                                    conPi++;
                                    sumPi += num;
                                }
                                else
                                {
                                    Console.WriteLine();
                                    conPi++;
                                    sumPi += num;
                                }
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                Console.Write($"{num} ");

                                if (num % Fa1 == 0 && num % Fa2 == 0 && num % Fa3 == 0)
                                {
                                    line += $" {num}[{Fa1},{Fa2},{Fa3}]";
                                }
                                else if (num % Fa1 == 0 && num % Fa2 == 0)
                                {
                                    line += $" {num}[{Fa1},{Fa2}]";
                                }
                                else if (num % Fa2 == 0 && num % Fa3 == 0)
                                {

                                    line += $" {num}[{Fa2},{Fa3}]";
                                }
                                else if (num % Fa3 == 0 && num % Fa1 == 0)
                                {
                                    line += $" {num}[{Fa1},{Fa3}]";
                                }


                                if (num % Fa1 == 0 || num % Fa2 == 0 || num % Fa3 == 0)
                                {
                                    if(num % Fa1 == 0 && num % Fa2 == 0 && num % Fa3 == 0)
                                    {
                                        conFa++;
                                        sumFa += num;
                                    }
                                    if (num % Fa1 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Write("＊");
                                        conFa1++;
                                        sumFa1 += num;
                                    }
                                    if (num % Fa2 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.Write("＊");
                                        conFa2++;
                                        sumFa2 += num;
                                    }
                                    if (num % Fa3 == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.Write("＊");
                                        conFa3++;
                                        sumFa3 += num;
                                    }
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.White;
                                }

                                else
                                {
                                    Console.WriteLine();
                                    conoth++;
                                    sumoth += num;
                                }
                            }
                            conn++;
                        }
                        Console.WriteLine();
                        Console.Write("質數的個數共");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(conPi);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sumPi);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。\n");

                        Console.Write("擁有您設定3個因數的個數共");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(conFa);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sumFa);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。\n");

                        Console.Write("擁有您設定因數1的個數共");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(conFa1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sumFa1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。\n");

                        Console.Write("擁有您設定因數2的個數共");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(conFa2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sumFa2);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。\n");

                        Console.Write("擁有您設定因數3的個數共");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(conFa3);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sumFa3);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。\n");

                        Console.Write("其餘數的個數共");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(conoth);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sumoth);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。\n");

                        Console.Write("公倍數:");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{line}\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;

                    }
                }
                catch (Exception ex)
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
                    System.Threading.Thread.Sleep(100);
                }
            }
        }

        static bool Prime(int xp)
        {
            if (xp == 1) return false;
            else if (xp == 2) return true;
            else if (xp % 2 == 0) return false;
            else
            {
                for (int i = 3; i < xp; i += 2)
                {
                    if (xp % i == 0) return false;
                }
                return true;
            }
        }
    }
}
