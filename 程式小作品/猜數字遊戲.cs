using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_GTN
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Random rd= new Random();
                    int ans ;
                    int con = 0;
                    int sc0 = 0;
                    int sc1 = 1000;
                    Console.WriteLine("---------------------猜數字遊戲-------------------------\n\n" +
                                      "========================================================\n" +
                                      "遊戲規則:系統會隨機生成'0~1000'一個數字，\n" +
                                      "這時請輸入生成範圍內的數字，如果猜中則遊戲通關並結束，\n"+
                                      "如果猜錯一定次數則系統會以亂數的形式逐漸縮小範圍直到猜對，\n"+
                                      "猜對為止前可輸入數字以外的字放棄本次遊戲。\n"+
                                      "========================================================");
                    Console.Write("請輸入Y開始遊戲:");
                    string y = Console.ReadLine();
                    if (y != "Y") continue;
                    Console.WriteLine("數字生成中，請等待三秒。");
                    System.Threading.Thread.Sleep(3001);
                    ans = rd.Next(0, 1001);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("數字已生成，開始本次遊戲!\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    
                    while (true)
                    {
                        if (con == 5)
                        {
                            sc0 = rd.Next(sc0, ans);
                            sc1 = rd.Next(ans, sc1);
                            System.Threading.Thread.Sleep(1001);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("本次縮小範圍:");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"{sc0}~{sc1}");
                            Console.WriteLine("請繼續遊戲\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            con = 0;
                            System.Threading.Thread.Sleep(1001);
                        }

                        Console.Write("請輸入(猜錯五次開始縮小範圍):");
                        string x = Console.ReadLine();
                        if(x=="")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("輸入錯誤，請重新輸入!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Threading.Thread.Sleep(1001);
                            continue;
                        }

                        int n = int.Parse(x);
                        if(n<sc0||n>sc1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("您猜的數字超出範圍，請重新輸入!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Threading.Thread.Sleep(1001);
                            continue;
                        }

                        if(n!=ans)
                        {
                            if (con == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("您已猜錯五次，將開始縮小範圍!");
                                Console.ForegroundColor = ConsoleColor.White;
                                con++;
                                continue;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("您猜錯了，請在嘗試一次!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            con++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("恭喜您成功猜中!本局遊戲已結束!");
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Threading.Thread.Sleep(1001);
                            break;
                        }

                    }
                    

                }
                catch(Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"您放棄本次遊戲!本次遊戲已結束");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("\n按任意鍵重新開始遊戲\n");
                    Console.ReadKey();
                }
            }
        }
    }
}
