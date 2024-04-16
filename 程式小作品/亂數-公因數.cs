using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_ta_text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Random rd = new Random();
                    int N, M, L, O, i, M1,j;
                    int a = 0, ans0 = 0;
                    int b = 0, ans1 = 0;
                    int c = 0, ans2 = 0;
                    int d = 0, ans3 = 0;
                    int e = 0, ans4 = 0;
                    int f = 0, ans5 = 0;
                    int g = 0, ans6 = 0;
                    int h = 0, ans7 = 0;
                    int k = 0, ans8 = 0;
                    int l = 0;

                    int Op0 = 0, Op = 0;
                    int Mp0 = 0, Mp = 0;
                    int Lp0 = 0, Lp = 0; ;
                    Console.WriteLine("===========================================================================\n" +
                                      "請輸入N以產生該值的1~1000的亂數，\n" +
                                      "並輸入因數O,因數M,因數L，\n" +
                                      "最後求出質數`各因數以及其餘數的個數與總和。\n"+
                                      "(綠＊代表是O的倍數，黃＊代表是M的倍數，紅＊代表是L的倍數，白＊代表質數)\n" +
                                      "===========================================================================");
                    Console.Write("N=");
                    string w = Console.ReadLine();
                    N = int.Parse(w);
                    Console.Write("因數O=");
                    string z = Console.ReadLine();
                    O = int.Parse(z);
                    Console.Write("因數M=");
                    string x = Console.ReadLine();
                    M = int.Parse(x);
                    Console.Write("因數L=");
                    string y = Console.ReadLine();
                    L = int.Parse(y);

                    checked
                    {
                        for (i = 1; i <= N; i++)
                        {
                            M1 = rd.Next(1, 1001);

                            for (j = 1; j <= M1; j++)
                            {
                                if (M1 % j == 0)
                                {
                                    l += 1;
                                }
                            }
                            if(O==M || M==L || L==O)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n因數重複，請重新輸入!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            }

                            if((O == M1 || O == 1 ) && l==2) 
                            {
                                Console.Write(i + ".     " + M1 + "     ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("＊");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("＊");
                                Op0 += M1;
                                Op++;

                            }
                            else if ((M == M1 || M == 1) && l==2)
                            {
                                Console.Write(i + ".     " + M1 + "     ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("＊");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("＊");
                                Mp0 += M1;
                                Mp++;
                            }
                            else if ((L == M1 || L == 1 ) && l==2)
                            {
                                Console.Write(i + ".     " + M1 + "     ");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("＊");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("＊");
                                Lp0 += M1;
                                Lp++;
                            }
                            else if (l == 2)
                            {
                                Console.WriteLine(i + ".     " + M1 + "     " + "＊");
                                ans0 += M1;
                                a++;
                            }
                            else
                            {

                                if (M1 % O == 0 && M1 % M == 0 && M1 % L == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("＊");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("＊");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans1 += M1;
                                    b++;
                                }
                                else if (M1 % O == 0 && M1 % M == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("＊");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans2 += M1;
                                    c++;
                                }
                                else if (M1 % M == 0 && M1 % L == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("＊");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans3 += M1;
                                    d++;
                                }
                                else if (M1 % O == 0 && M1 % L == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("＊");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans4 += M1;
                                    e++;
                                }
                                else if (M1 % O == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans5 += M1;
                                    f++;
                                }
                                else if (M1 % M == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans6 += M1;
                                    g++;
                                }
                                else if (M1 % L == 0)
                                {
                                    Console.Write(i + ".     " + M1 + "     ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("＊");
                                    Console.ForegroundColor = ConsoleColor.White;

                                    ans7 += M1;
                                    h++;
                                }
                                else
                                {
                                    Console.WriteLine(i + ".     " + M1 + "     ");

                                    ans8 += M1;
                                    k++;
                                }
                            }
                            l = 0;
                        }
                        if(a==0 && b==0 && c==0 && d== 0 && e== 0 && f== 0 && g== 0 && h== 0 && k== 0) continue;

                        Console.Write("質數共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(a + Mp + Lp + Op);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans0 + Mp0 + Lp0 + Op0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。");

                        Console.Write("\n能被O，M，L整除共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(b);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans1);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。");


                        Console.Write("\n只能被O整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(f+Op);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans5+Op0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("之所得值。\n能被O整除共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(f + e + c+ b + Op);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans5 + ans4 + ans2 +ans1 + Op0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。");

                        Console.Write("\n只能被M整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(g+Mp);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans6+Mp0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("之所得值。\n能被M整除共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(g + d + c + b + Mp);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans6 + ans3 + ans2 + ans1 + Mp0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。");

                        Console.Write("\n只能被L整除的共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(h+Lp);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans7+Lp0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("之所得值。\n能被L整除共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(h + e + d + b + Lp);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans7 + ans4 + ans3 + ans1 + Lp0);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。");

                        Console.Write("\n其餘共");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(k);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("個，總和為");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(ans8);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("之所得值。");
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Random rd = new Random();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\nAuto!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(rd.Next(100, 1001));
                }
            }
        }
    }
}
