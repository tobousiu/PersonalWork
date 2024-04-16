using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    decimal sa;
                    string line = "";
                    decimal con = 0;
                    decimal nn = 0;
                    Console.WriteLine("[1]求介於兩個整數之間[2,501]因數(不含1與本身)與質數？？");
                    Console.WriteLine("[2]求介於兩個整數之間[0,9876543210]的Factorial、Fibonacci？？");
                    string[] x = Console.ReadLine().Split(' ');
                    if (x.Length != 3) continue;
                    decimal n1 = decimal.Parse(x[1]);
                    decimal n2 = decimal.Parse(x[2]);

                    switch(x[0])
                    {
                        case "1":
                            if(n1<2 || n1>501)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("數字範圍[2,501]錯誤");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }

                            if (n2 < 2 || n2 > 501)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("數字範圍[2,501]錯誤");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }

                            if(n2<n1)
                            {
                                sa = n2;
                                n2 = n1;
                                n1 = sa;
                            }
                            Console.WriteLine();

                            while(n1<=n2)
                            {
                                if(Prime(n1))
                                {
                                    Console.Write($"{n1}:");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("[質數]");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    for (decimal i = 2; i < n1; i++)
                                    {
                                        if (n1 % i == 0)
                                        {
                                            line += $"{i}, ";
                                        }
                                    }
                                    Console.Write($"{n1}:");
                                    Console.WriteLine(line.Substring(0,line.Length-2));
                                }
                                line = "";
                                n1++;
                            }


                            break;

                        case "2":
                            if (n1 < 0 || n1 > 9876543210)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("數字範圍[0,9876543210]錯誤錯誤");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }

                            if (n2 < 0 || n2 > 9876543210)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("數字範圍[0,9876543210]錯誤錯誤");
                                Console.ForegroundColor = ConsoleColor.White;
                                continue;
                            }

                            if(n2<n1)
                            {
                                sa = n2;
                                n2 = n1;
                                n1 = sa;
                            }

                            Console.WriteLine("\nFactorial(階乘)：");
                            while(con!=1)
                            {
                                if(FACT(nn)>=n1)
                                {
                                    if (FACT(nn) > n2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"{nn}! ={FACT(nn)}");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        con++;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"{nn}! ={FACT(nn)}");
                                    }
                                }
                                nn++;
                            }
                            nn = 0;
                            con = 0;

                            Console.WriteLine("\nFactorial(階乘)：");
                            while (con != 1)
                            {
                                if (FIBO(nn) >= n1)
                                {
                                    if (FIBO(nn) > n2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"Fibonacci({nn}) = {FIBO(nn)}");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        con++;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Fibonacci({nn}) = {FIBO(nn)}");
                                    }
                                }
                                nn++;
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
                    Console.WriteLine("\nPress any key try again！\n");
                }
            }
        }
        
        static bool Prime(decimal X0)
        {
            decimal num;
            if (X0 == 1) return false;
            else if (X0 == 2) return true;
            else if (X0 % 2 == 0) return false;
            else
            {
                for (decimal i = 3; i * i <= X0; i+=2)
                {
                    if (X0 % i == 0) return false;
                }
                return true;
            }
        }

        static decimal FACT(decimal X1)
        {
            decimal pro = 1;
            for(decimal i=1;i<=X1;i++)
            {
                pro *= i;
            }
            return pro;
        }

        static decimal FIBO(decimal X2)
        {
            if (X2 == 0) return 0;
            else if (X2 == 1) return 1;
            else
            {
                decimal Fn = 0;
                decimal F1 = 0;
                decimal F2 = 1;
                decimal F = 2;
                while(F<=X2)
                {
                    Fn = F1 + F2;
                    F1 = F2;
                    F2 = Fn;
                    F++;
                }
                return Fn;
            }
        }
    }
}
