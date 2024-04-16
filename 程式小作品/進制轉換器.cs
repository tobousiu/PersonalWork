using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_bytetype
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    Console.WriteLine("==================================\n" +
                                      "請選擇方案:\n" +
                                      "A方案:10進位轉n進位\n"+
                                      "B方案:n進位轉10進位\n"+
                                      "==================================");
                    Console.Write("請輸入方案(A or B):");
                    string plan = Console.ReadLine();

                    switch (plan)
                    {
                        case "A":
                            Console.Write("\n您選擇的是A方案，\n"+
                                          "請輸入要進行轉換的進制(n=?):");
                            string n1 = Console.ReadLine();
                            int c0 = int.Parse(n1);
                            Console.Write("請輸入要進行轉換的數值:");
                            string a = Console.ReadLine();
                            int c1 = Convert.ToInt32(a);

                            Console.Write("\n轉換結果為:");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(Convert.ToString(c1,c0));
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        case "B":
                            Console.Write("\n您選擇的是B方案，\n" +
                                          "請輸入要進行轉換的進制(n=?):");
                            string n2 = Console.ReadLine();
                            int c2 = int.Parse(n2);
                            Console.Write("請輸入要進行轉換的數值:");
                            string b = Console.ReadLine();

                            Console.Write("\n轉換結果為:");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine(Convert.ToInt32(b,c2));
                            Console.ForegroundColor = ConsoleColor.White;
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("您輸入的方案錯誤，請重新輸入。");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                    } 
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\n");
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
    }
}
