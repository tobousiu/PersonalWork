using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_ta_FIBO
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int con = 0;
            while(true)
            {
                try
                {
                    Console.WriteLine("==============================\n" +
                                      "依所選功能輸出，\n" +
                                      "正整數Ｘ～Ｙ之費氏數列。\n" +
                                      "==============================\n" +
                                      "功能選項：\n" +
                                      "Ａ：正常輸出\n" +
                                      "Ｂ：倒敘輸出\n" +
                                      "Ｃ：只輸出偶數\n" +
                                      "Ｄ：只輸出奇數\n" +
                                      "Ｅ：標示質數\n" +
                                      "==============================");
                    Console.Write("Ｘ、Ｙ、功能＝");
                    string[] x = Console.ReadLine().Split(' ');
                    if (x.Length != 3) continue;
                    int n1 = int.Parse(x[0]);
                    int n2 = int.Parse(x[1]);

                    if (n1 > n2)
                    {
                        num1 = n2;
                        num2 = n1;
                    }
                    else
                    {
                        num1 = n1;
                        num2 = n2;
                    }

                    switch (x[2])
                    {
                        case "A":
                            while(num1<=num2)
                            {
                                if(FIBO(num1)==-1)
                                {
                                    Console.WriteLine($"{num1}小於0");
                                }
                                else
                                {
                                    Console.WriteLine($"{num1}.        {FIBO(num1)}");
                                }

                                num1++;
                            }
                            break;

                        case "B":
                            for(int i=num2;num2>=num1;num2--)
                            {
                                if(FIBO(num2)==-1)
                                {
                                    Console.WriteLine($"{num2}小於0");
                                }
                                else
                                {
                                    Console.WriteLine($"{num2}.        {FIBO(num2)}");
                                }
                            }
                            break;

                        case "C":
                            while (num1 <= num2)
                            {
                                if (FIBO(num1) == -1)
                                {
                                    Console.WriteLine($"{num1}小於0");
                                }
                                else
                                {
                                    if (FIBO(num1) % 2 == 0)
                                    {
                                        Console.WriteLine($"{num1}.        {FIBO(num1)}");
                                    }
                                }

                                num1++;
                            }
                            break;

                        case "D":
                            while (num1 <= num2)
                            {
                                if (FIBO(num1) == -1)
                                {
                                    Console.WriteLine($"{num1}小於0");
                                }
                                else
                                {
                                    if (FIBO(num1) % 2 != 0)
                                    {
                                        Console.WriteLine($"{num1}.        {FIBO(num1)}");
                                    }
                                }

                                num1++;
                            }
                            break;

                        case "E":
                            while (num1 <= num2)
                            {
                                if (FIBO(num1) == -1)
                                {
                                    Console.WriteLine($"{num1}小於0");
                                }
                                else
                                {
                                    for (int i = 1; i <= FIBO(num1); i++)
                                    {
                                        if (FIBO(num1) % i == 0)
                                        {
                                            con++;
                                        }
                                    }

                                    if(con==2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"{num1}.        {FIBO(num1)}");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{num1}.        {FIBO(num1)}");
                                    }

                                }
                                con = 0;
                                num1++;
                            }
                            break;

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
                    Console.WriteLine("按任意鍵繼續...");
                    Console.ReadKey();
                }
            }
        }

        static decimal FIBO(int X)
        {
            decimal F1 = 0, F2 = 1, Fn = 0;
            int f = 2;
            if (X < 0) return -1;
            else if (X == 0 ) return 0;
            else if (X == 1) return 1;
            else
            {
                while(f<=X)
                {
                    Fn = F1 + F2;
                    F1 = F2;
                    F2 = Fn;
                    f++;
                }
                return Fn;
            }
        }

    }
}
