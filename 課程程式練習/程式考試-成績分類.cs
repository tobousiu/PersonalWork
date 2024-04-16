using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Random rd = new Random();
                    int n,i,ans;
                    int a = 0;
                    int b = 0;
                    int c = 0;
                    int d = 0;
                    int e = 0;
                    double ans0 = 0;
                    double ans1 = 0;
                    double ans2 = 0;
                    double ans3 = 0;
                    double ans4 = 0;
                    string line="";
                    Console.WriteLine("成績分級？A[100-85]；B[84-70]；C[69-60]；Fail[59-30](基本分30)");
                    Console.WriteLine("Press <Enter> for Return");
                    Console.Write("C#學期成績模擬(人數)？");
                    string x = Console.ReadLine();
                    if (x == "") return;
                    n = int.Parse(x);
                    if (n == 0) return;

                    checked
                    {
                        for(i=1;i<=n;i++)
                        {
                            ans = rd.Next(30,101);
                            Console.Write(i + ". " + ans + ".....");
                            if(ans== 100)
                            {
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("A");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Black;
                                e++;
                                ans4 = ans;
                                line += i + "(100)";

                            }
                            else if (ans < 100 && ans>=85)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("A");
                                Console.ForegroundColor = ConsoleColor.White;
                                a++;
                                ans0 += ans;
                            }
                            else if (ans < 85 && ans >= 70)
                            {
                                Console.WriteLine("B");
                                b++;
                                ans1 += ans;
                            }
                            else if (ans < 70 && ans >= 60)
                            {
                                Console.WriteLine("C");
                                c++;
                                ans2 += ans;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Fail");
                                Console.ForegroundColor = ConsoleColor.White;
                                d++;
                                ans3 += ans;
                            }
                        }
                        Console.WriteLine("\n全班平均成績："+Math.Round(((ans0+ans1+ans2+ans3+ans4)/n),1,MidpointRounding.AwayFromZero));
                        Console.WriteLine("PASS[>=60]人數："+(a+b+c+e));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fail[< 60]人數："+d);
                        Console.ForegroundColor = ConsoleColor.White;

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("滿分名單：");
                        Console.WriteLine(line+"\n");
                        Console.ForegroundColor = ConsoleColor.White;


                    }

                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    System.Threading.Thread.Sleep(100);
                }
            }
        }
    }
}
