using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_PrimeGL_ta2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int num1, num2;
                    int con = 1;
                    Console.WriteLine("=================================================\n" +
                                      "功能選項：\n" +
                                      "A：找出Ｘ個Ｙ以上(含Y)的質數\n" +
                                      "B：找出Ｘ及Ｙ的所有公因數&最小公倍數&最大公因數\n" +
                                      "C：找出Ｘ個Ｙ以下(含Y)的質數\n" +
                                      "=================================================");
                    Console.Write("功能？ Ｘ？ Ｙ？＝");
                    string[] x = Console.ReadLine().Split(' ');
                    if (x.Length != 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("輸入格式不正確!");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                    int n1 = int.Parse(x[1]);
                    int n2 = int.Parse(x[2]);

                    switch (x[0])
                    {
                        case "A":
                            while (con <= n1)
                            {
                                if (Prime(n2))
                                {
                                    Console.WriteLine($"{con}. {n2}");
                                    con++;
                                }
                                n2++;
                            }
                            break;

                        case "B":
                            if (n1 < n2)
                            {
                                num1 = n1;
                                num2 = n2;
                            }
                            else
                            {
                                num1 = n2;
                                num2 = n1;
                            }

                            if (num1 < 0 || num2 < 0)
                            {
                                num1 = Math.Abs(num1);
                                num2 = Math.Abs(num2);
                            }

                            decimal LCM =Math.Abs(n1 * n2 / maxFACT(num1, num2));

                            Console.WriteLine($"({n1},{n2})所有公因數:{FACT(num1, num2).Substring(0,FACT(num1, num2).Length - 1)}");
                            Console.WriteLine($"({n1},{n2})最大公因數:{maxFACT(num1,num2)}");
                            Console.WriteLine($"({n1},{n2})最小公倍數:{LCM}({PLCM(LCM).Substring(0,PLCM(LCM).Length-1)})");

                            break;

                        case "C":
                            while (n2>0)
                            {
                                if (Prime(n2))
                                {
                                    if (con <= n1)
                                    {
                                        Console.WriteLine($"{con}. {n2}");
                                    }
                                    con++;
                                }
                                n2--;
                            }
                            break;
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
                    System.Threading.Thread.Sleep(1001);
                }
            }
        }

        static bool Prime(decimal X)
        {
            decimal g = 0;
            decimal num = X;
            decimal pro = 0;
            decimal sum = 0;
            while (num != 0)
            {
                g = num % 10;
                pro = num / 10;
                if (pro % 1 != 0)
                {
                    pro = (decimal)Math.Floor((double)pro);
                }
                sum += g;
                num = pro;
            }

            if (X == 1) return false;
            else if (X == 2) return true;
            else if (X % 2 == 0) return false;
            else if (X == 3) return true;
            else if (sum % 3 == 0) return false;
            else
            {
                //decimal sq = (decimal)Math.Floor((double)Math.Sqrt((double)X));
                for (int i = 5; i * i <= X; i++)
                {
                    if (X % i == 0) return false;
                }
                return true;

            }
        }

        static string FACT(decimal X0, decimal X1)
        {
            string line1 = "";
            decimal i = 1;
            while (i <= X0)
            {
                if (X0 % i == 0 && X1 % i == 0)
                {
                    line1 += $"{i}、";
                }
                i++;
            }
            return line1;
        }

        static decimal maxFACT (decimal X0, decimal X1)
        {
            decimal g;
            while (X1%X0 != 0)
            {
                g = X1 % X0;
                X1 = X0;
                X0 = g;
            }
            return X0;
        }

        static string PLCM(decimal X)
        {
            string line2="";
            decimal i = 1;
            while(i*i<=X)
            {
                if(X%i==0)
                {
                    line2 += $"{i}*{X / i}、";
                }
                i++;
            }
            return line2;
        }
        
    }
}
