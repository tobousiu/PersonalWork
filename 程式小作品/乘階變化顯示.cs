using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    decimal p1 = 1, p2 = 1, p3=1 ;
                    decimal sa;
                    decimal con = 0;
                    decimal num1, num2;
                    Console.WriteLine("===========================================================\n" +
                                      "輸入n值來決定最後乘階輸出\n"+
                                      "輸出規則:\n"+
                                      "A:正常輸出(需有計算過程)\n"+
                                      "B:正常輸出(計算過程相反顯示)\n"+
                                      "C:再輸入一個數輸出該值~n之間所有的乘階\n"+
                                      "D:再輸入一個值變成組合數\n"+
                                      "E:再輸入一個值變成排列數\n"+
                                      "===========================================================");
                    Console.Write("請輸入(方案 n值):");
                    string[] x = Console.ReadLine().Split(' ');
                    if (x.Length!=2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n輸入的格式錯誤!");
                        Console.ForegroundColor = ConsoleColor.White;
                        System.Threading.Thread.Sleep(1001);
                        continue;
                    }
                    decimal n = decimal.Parse(x[1]);

                    switch(x[0])
                    {
                        case "A":

                            if(n<0)
                            {
                                Console.WriteLine($"{n}!之值小於0");
                                break;
                            }
                            Console.WriteLine($"{n}!={factorial1(n)}");
                            
                            break;

                        case "B":

                            if (n < 0)
                            {
                                Console.WriteLine($"{n}!之值小於0");
                                break;
                            }
                            Console.WriteLine($"{n}!={factorial2(n)}");

                            break;

                        case "C":
                            Console.Write("請再輸入一個數:");
                            string y = Console.ReadLine();
                            if (y == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n輸入錯誤!");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(1001);
                                continue;
                            }
                            decimal nn = decimal.Parse(y);


                            if(nn<0)
                            {
                                while(nn<0 && nn<=n)
                                {
                                    Console.WriteLine($"{nn}!之值小於0");
                                    nn++;
                                }
                            }

                            if(nn<=n)
                            while (con<=n)
                            {
                                if (con >= nn)
                                {
                                    Console.WriteLine($"{con}!={factorial1(con)}");
                                }
                                con++;
                            }
                            else
                            {
                                while (nn >= n)
                                {

                                    Console.WriteLine($"{nn}!={factorial2(nn)}");
                                    nn--;
                                }
                            }

                            break;

                        case "D":
                            decimal d1;
                            decimal d2;
                            Console.Write("請再輸入一個數:");
                            string x0 = Console.ReadLine();
                            if(x0=="")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n輸入錯誤!");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(1001);
                                continue;
                            }
                            decimal n0 = decimal.Parse(x0);

                            if (n0 < 0 || n<0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n該值小於0!");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(1001);
                                continue;
                            }

                            if(n0>n)
                            {
                                num1 = n0;
                                num2 = n;
                            }
                            else
                            {
                                num1 = n;
                                num2 = n0;
                            }

                            if((num1-num2)>num2)
                            {
                                d1 = (num1 - num2);
                                d2 = num2;
                            }
                            else
                            {
                                d1 = num2;
                                d2 = (num1 - num2);
                            }

                            for(decimal i1=d1+1;i1<=num1;i1++)
                            {
                                p1 *= i1;
                            }

                            for(decimal i2=1;i2<=d2;i2++)
                            {
                                p2 *= i2;
                            }

                            Console.WriteLine($"C({num1},{num2})={p1/p2}");

                            break;

                        case "E":
                            Console.Write("請再輸入一個數:");
                            string x1 = Console.ReadLine();
                            if (x1 == "")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n輸入錯誤!");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(1001);
                                continue;
                            }
                            decimal n1 = decimal.Parse(x1);

                            if (n1 < 0 || n<0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"\n該值小於0!");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(1001);
                                continue;
                            }

                            if (n1 > n)
                            {
                                num1 = n1;
                                num2 = n;
                            }
                            else
                            {
                                num1 = n;
                                num2 = n1;
                            }

                            for (decimal i3 = num2 + 1; i3 <= num1; i3++)
                            {
                                p3 *= i3;
                            }

                            Console.WriteLine($"P({num1},{num2})={p3}");

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
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nAuto!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(1001);
                }
            }
        }

        static string factorial1(decimal X1)
        {
            string line1 = "";
            decimal pro1 = 1;

            if (X1 == 0) return "0";
            else if (X1 == 1) return "1";
            else
            {
                for (decimal i = 1; i <= X1; i++)
                {
                    if (i == X1)
                    {
                        line1 += $"{i} =";
                    }
                    else
                    {
                        line1 += $"{i} X ";
                    }
                    pro1 *= i;
                }
            }
            return line1+pro1;
        }

        static string factorial2(decimal X2)
        {
            decimal pro2 = 1;
            string line2 = "";
            for(decimal i=X2;i>0;i--)
            {
                if(i==1)
                {
                    line2 += $"{i} =";
                }
                else
                {
                    line2 += $"{i} X ";
                }
                pro2 *= i;
            }
            return line2 + pro2;
        }

    }
}
