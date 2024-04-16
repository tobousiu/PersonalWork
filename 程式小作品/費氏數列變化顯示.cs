using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_FIBOcase
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    int con = 1;
                    int nn = 0;
                    Console.WriteLine("===============================================\n" +
                                      "輸入一個n值產生n次的輸出結果，\n"+
                                      "並在輸入你要的方案決定輸出方式。\n"+
                                      "方案規則:\n"+
                                      "A:正常輸出\n"+
                                      "B:倒敘輸出\n"+
                                      "C:再輸入1個數限制輸出數列範圍\n"+
                                      "D:只顯示偶數\n"+
                                      "E:只顯示奇數\n"+
                                      "F:輸出質數時變綠色\n"+
                                      "G:如果該項內的數字偶數個數大於奇數個數時輸出\n"+
                                      "H:如果該項內的數字奇數個數大於偶數個數時輸出\n"+
                                      "I:如果該項內的數字奇數個數等於偶數個數時輸出\n" +
                                      "================================================");
                    Console.Write("請輸入(n值 方案):");
                    string[] x = Console.ReadLine().Split(' ');
                    if (x.Length != 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n輸入格式有誤");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(1001);
                        continue;
                    }
                    int n = int.Parse(x[0]);
                    Console.WriteLine();

                    if(FIBO(n)==-1)
                    {
                        Console.WriteLine($"{n}未大於0");
                    }

                    if(FIBO(n)==0)
                    {
                        Console.WriteLine($"{n}. {FIBO(n)}");
                    }

                    switch(x[1])
                    {
                        case "A":

                            while(nn<n)
                            {
                                nn++;
                                Console.Write($"{nn}. {FIBO(con)}");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($" (數列第{con}項)");
                                Console.ForegroundColor = ConsoleColor.White;
                                con++;
                            }

                            break;

                        case "B":

                            while (n>0)
                            {
                                nn++;
                                Console.Write($"{nn}. {FIBO(n)}");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine($" (數列第{n}項)");
                                Console.ForegroundColor = ConsoleColor.White;
                                n--;
                            }

                            break;

                        case "C":
                            int sa;
                            Console.Write("請再輸入一個數:");
                            string x0 = Console.ReadLine();
                            if (x0 == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n輸入格式有誤");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(1001);
                                continue;
                            }
                            int n0 = int.Parse(x0);

                            if(n0>n)
                            {
                                sa = n;
                                n = n0;
                                n0 = sa;
                            }

                            while (con <= n)
                            {
                                if (con >= n0)
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                            }

                            break;

                        case "D":

                            while (nn < n)
                            {
                                if (FIBO(con) % 2 == 0)
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                            }

                            break;

                        case "E":

                            while (nn < n)
                            {
                                if (FIBO(con) % 2 != 0)
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                            }

                            break;

                        case "F":
                            int con0 = 0;

                            while (nn < n)
                            {
                                for(int i=1;i<=FIBO(con);i++)
                                {
                                    if(FIBO(con)%i==0)
                                    {
                                        con0++;
                                    }    
                                }

                                if (con0 == 2)
                                {
                                    nn++;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                                con0 = 0;
                            }

                            break;

                        case "G":

                            while (nn < n)
                            {
                                if (evod(con)==2)
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                            }

                            break;

                        case "H":

                            while (nn < n)
                            {
                                if(evod(con)==1)
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                            }

                            break;

                        case "I":

                            while (nn < n)
                            {
                                if (evod(con) == 0)
                                {
                                    nn++;
                                    Console.Write($"{nn}. {FIBO(con)}");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine($" (數列第{con}項)");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                con++;
                            }

                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("沒有這個方案，請重選!");
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Threading.Thread.Sleep(1001);
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

        static decimal FIBO(decimal X)
        {
            decimal Xn = 0;
            decimal X1 = 0;
            decimal X2 = 1;
            decimal f = 2;
            if (X < 0) return -1;
            else if (X == 0) return 0;
            else if (X == 1) return 1;
            else
            {
                while(f<=X)
                {
                    Xn = X1 + X2;
                    X1 = X2;
                    X2 = Xn;
                    f++;
                }
                return Xn;
            }
        }

        static decimal evod(decimal Y)
        {
            decimal g = 0;
            decimal pro = 0;
            decimal num = 0;
            decimal ev = 0;
            decimal od = 0;

            num = FIBO(Y);
            while(num!=0)
            {
                g = num % 10;
                pro = num / 10;

                if(pro%1!=0)
                {
                    pro-=(pro%1);
                }

                if(g%2==0)
                {
                    ev++;
                }
                else
                {
                    od++;
                }

                num = pro;
            }

            if (ev > od)
            {
                return 2;
            }
            else if(od>ev)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

}
