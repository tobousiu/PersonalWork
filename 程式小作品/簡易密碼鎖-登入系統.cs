using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_codelock
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            string cer;
            const int maxline = 12;
            const int minline = 6;

            if (line == "")
            {
                Console.WriteLine("---未偵測有設定任何密碼，請設定密碼---\n"+
                                  "-----設定密碼時，請輸入6~12個字。-----\n");
            }
            while (line == "")
            {
                Console.Write("請輸入密碼:");
                string x = Console.ReadLine();
                if (x.Length < minline)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n密碼太短，請重新輸入!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else if (x.Length > maxline)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n密碼太長，請重新輸入!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;

                }
                Console.Write("請再次輸入密碼:");
                string y = Console.ReadLine();
                if(x!=y)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n密碼不一致，請重新輸入!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                else
                {
                    line = y;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n密碼設定完成!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }

            while (true)
            {
                Console.WriteLine("\n-請設定您的身分認證，用於忘記密碼系統使用的認證碼-\n" +
                                    "---------可隨意輸入只有您自己知道的認證碼---------\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("請注意!設定完畢後將無法進行任何更改，\n" +
                                  "請確保記住並保管好您的身分認證碼，\n" +
                                  "以免無法進行忘記密碼系統以及密碼被盜。\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("請輸入身分認證碼:");
                string w = Console.ReadLine();
                Console.WriteLine("\n確定本次輸入結果作為您身分認證?(進行3次確認)");
                Console.Write("一次確認(請輸入Y確認，輸入其他則取消確認並要重新輸入認證碼):");
                string w1 = Console.ReadLine();
                if (w1 != "Y") continue;
                Console.Write("二次確認(請輸入Y確認，輸入其他則取消確認並要重新輸入認證碼):");
                string w2 = Console.ReadLine();
                if (w2 != "Y") continue;
                Console.Write("最後確認(請輸入Y確認，輸入其他則取消確認並要重新輸入認證碼):");
                string w3 = Console.ReadLine();
                if (w3 != "Y") continue;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n認證完畢!5秒後進入系統頁面!請確實保管認證碼!\n");
                Console.ForegroundColor = ConsoleColor.White;
                cer = w;
                System.Threading.Thread.Sleep(5001);
                break;
            }

            while (true)
            {
                try
                {
                    Console.Write("=====================================\n"+
                                  "密碼鎖規則:\n"+
                                  "1.設定密碼時，請輸入6~12個字。\n"+
                                  "2.擁有密碼時，如需更換請輸入change。\n"+
                                  "3.如果忘記密碼，請輸入clean進行重設。\n"+
                                  "4.如需進行登入，請輸入login。\n"+
                                  "=====================================\n"+
                                  "請輸入要進行的模式(login or clean or change):");
                    string z = Console.ReadLine();
                    if (z == "") continue;

                    switch (z)
                    {
                        case "clean":
                            Console.Write("\n您進入到-忘記密碼-的系統，\n"+
                                          "如要繼續請輸入Y，輸入其他則跳回系統頁面。\n"+
                                          "請輸入:");
                            string clean1 = Console.ReadLine();
                            if(clean1!="Y")
                            {
                                Console.WriteLine("將跳回系統頁面，請等待5秒!\n");
                                System.Threading.Thread.Sleep(5001);
                                continue;
                            }

                            Console.WriteLine("\n請輸入您的身分認證碼。");
                            Console.Write("認證碼(錯誤一次將跳回系統頁面):");
                            string cer1 = Console.ReadLine();
                            if(cer1!=cer)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n輸入錯誤!5秒後跳回系統頁面!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                System.Threading.Thread.Sleep(5001);
                                continue;
                            }

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n輸入正確!密碼已清除!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            line = "";
                            while (line == "")
                            {
                                Console.Write("請輸入密碼:");
                                string clean2 = Console.ReadLine();
                                if (clean2.Length < minline)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n密碼太短，請重新輸入!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }
                                else if (clean2.Length > maxline)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n密碼太長，請重新輸入!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;

                                }
                                Console.Write("請再次輸入密碼:");
                                string clean3 = Console.ReadLine();
                                if (clean2 != clean3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n密碼不一致，請重新輸入!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }
                                else
                                {
                                    line = clean3;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n密碼設定完成!將自動回到系統主頁\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }

                                continue;

                        case "change":
                            Console.Write("\n您進入到-更換密碼-的系統，\n" +
              "如要繼續請輸入Y，輸入其他則跳回系統頁面。\n" +
              "請輸入:");
                            string change1 = Console.ReadLine();
                            if (change1 != "Y")
                            {
                                Console.WriteLine("將跳回系統頁面，請等待5秒!\n");
                                System.Threading.Thread.Sleep(5001);
                                continue;
                            }

                            while (true)
                            {
                                Console.Write("\n請輸入原密碼(輸入R回到系統頁面):");
                                string change2 = Console.ReadLine();
                                if (change2 == "R")
                                {
                                    Console.WriteLine("將跳回系統頁面，請等待5秒!\n");
                                    System.Threading.Thread.Sleep(5001);
                                    break;
                                }
                                if (change2 != line)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n輸入錯誤，請重新輸入!");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\n原密碼正確!\n");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("請輸入新密碼:");

                                string change3 = Console.ReadLine();
                                if (change3.Length < minline)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n密碼太短，請重新輸入!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }
                                else if (change3.Length > maxline)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n密碼太長，請重新輸入!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;

                                }
                                Console.Write("請再次輸入新密碼:");
                                string change4 = Console.ReadLine();
                                if (change3 != change4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n密碼不一致，請重新輸入!\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }
                                else
                                {
                                    line = change4;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n密碼設定完成!將自動回到系統主頁\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                }
                            }
                            continue;

                        case "login":
                            int e = 0;
                            Console.Write("\n您進入到-登入-的系統，\n" +
              "如要繼續請輸入Y，輸入其他則跳回系統頁面。\n" +
              "請輸入:");
                            string login1 = Console.ReadLine();
                            if (login1 != "Y")
                            {
                                Console.WriteLine("將跳回系統頁面，請等待5秒!\n");
                                System.Threading.Thread.Sleep(5001);
                                continue;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n如果輸入錯誤3次，將跳回系統頁面!");
                            Console.ForegroundColor = ConsoleColor.White;
                            while (e != 4)
                            {
                                if(e==3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n已輸入錯誤3次!5秒後跳回系統頁面\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    System.Threading.Thread.Sleep(5001);
                                    e++;
                                    continue;
                                }
                                Console.Write("\n請輸入密碼:");
                                string login2 = Console.ReadLine();

                                Console.Write("請再次輸入密碼:");
                                string login3 = Console.ReadLine();
                                if (login2 == line && login2 == login3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("\n您成功登入!歡迎您!\n"+
                                                      "五秒後將跳出登入系統!\n" );
                                    Console.ForegroundColor = ConsoleColor.White;
                                    System.Threading.Thread.Sleep(5001);
                                    break;
                                }
                                else
                                {
                                    if (e != 2)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("密碼不一致，請重新輸入!");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        e++;
                                    }
                                    else
                                    {
                                        e++;
                                        continue;
                                    }
                                }
                            }
                            if (e != 4)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n尚未有這項系統，請重新輸入!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;

                    }
                    break;
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"\n{ex.Message}\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
