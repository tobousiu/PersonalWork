using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQ3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eratostosnes ET=new Eratostosnes();
            ET.create();
            while(true)
            {
                try
                {
                    long ch;
                    int num = 1;
                    Console.WriteLine(System.DateTime.Now);
                    Console.Write("[B]Balanced prime？？ [F]Fibonacci Prime(uint)？？ [T]Twin prime(p,p+2)？");
                    string[] x=Console.ReadLine().Split(' ');
                    long num1=int.Parse(x[1]);
                    long num2=int.Parse(x[2]);
                    if(num1>num2)
                    {
                        ch = num1;
                        num1 = num2;
                        num2 = ch;
                    }
                    long[] P=new long[num2+2];


                    switch (x[0])
                    {
                        case "B":


                            for (int i = 1; i <= num2+1;)
                            {
                                num++;
                                if (ET.text(num))
                                {
                                    P[i] = num;
                                    i++;
                                }
                            }

                            for (long j = num1; j <= num2; j++)
                            {
                                if((P[j-1]+P[j+1])/2==P[j])
                                {
                                    Console.ForegroundColor=ConsoleColor.Green;
                                    Console.WriteLine($"P{j}= {P[j]}......Balanced prime {P[j - 1]}＋{P[j + 1]}＝{P[j]}＊２");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.WriteLine($"P{j}= {P[j]}");
                                }
                            }

                            break;

                        case "F":

                                while (num1 <= num2 && num1 >= 0)
                                {
                                    Console.Write($"P{num1}= {Fibonacci((uint)num1)}");

                                    if (ET.text((uint)Fibonacci((uint)num1)) && num1 <= 13)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(".....Prime Number");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    Console.WriteLine();
                                    num1++;
                                }
                            

                            break;

                        case "T":

                            for (int i = 1; i <= num2;)
                            {
                                num++;
                                if (ET.text(num))
                                {
                                    if (i >= num1)
                                    {
                                        if (ET.text(num) && ET.text(num + 2))
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine($"({num},{num + 2})");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"P{i}={num}");
                                        }
                                    }
                                    i++;
                                }

                            }
                            break;

                        default:
                            break;
                    }

                }
                catch(Exception ex)
                {
                    Console.ForegroundColor=ConsoleColor.Red;
                    Console.WriteLine("\n"+ex.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("\n\n");
                }
            }
        }
        static decimal Fibonacci(uint X1)
        {
            checked
            {
                uint Fn = 0;
                uint F0 = 0;
                uint F1 = 1;
                uint f = 2;
                if (X1 < 0) return -1;
                else if (X1 == 0) return 0;
                else if (X1 == 1) return 1;
                else
                {
                    while (f <= X1)
                    {
                        Fn = F0 + F1;
                        F0 = F1;
                        F1 = Fn;
                        f++;
                    }
                    return Fn;
                }
            }
        }
    }
}
