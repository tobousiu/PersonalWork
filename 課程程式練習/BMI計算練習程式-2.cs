using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS20211118_L9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Random RD = new Random();
                double BMI, wcm, hcm, gcm;
                bool sx;

                try
                {
                    Console.WriteLine("\n**************************************************\n");
                    Console.WriteLine("BMI(Body Mass Index)");
                    Console.WriteLine("資料來源: http://zh.wikipedia.org/wiki/身高體重指數");
                    Console.WriteLine("\n==================================================\n");
                    Console.Write("請輸入性別-女[Female](0/f/F)男[Male](1/m/M)？");
                    string FM = Console.ReadLine();

                    checked
                    {
                        if( FM=="1" || FM=="m" || FM=="M" )
                        {
                            sx = true;
                            Console.WriteLine("true!");
                            Console.WriteLine("性別: 男");
                        }
                        else if(FM == "0" || FM == "f" || FM == "F")
                        {
                            sx = false;
                            Console.WriteLine("false!");
                            Console.WriteLine("性別: 女");
                        }
                        else
                        {
                            Console.WriteLine("性別錯誤!");
                            continue;
                        }
                        Console.Write("請輸入腰圍:");
                        string xwcm = Console.ReadLine();
                        Console.Write("請輸入身高:");
                        string xhcm = Console.ReadLine();
                        Console.Write("請輸入體重:");
                        string xgcm = Console.ReadLine();

                        wcm = double.Parse(xwcm);
                        hcm = double.Parse(xhcm);
                        gcm = double.Parse(xgcm);
                        BMI = gcm / Math.Pow(hcm, 2);
                        Console.WriteLine("BMI[體指數: " + BMI + " ]" + " = " + Math.Round(BMI, 2));

                        if (BMI < 18.5) 
                        {
                           Console.WriteLine("體重過輕");
                        }
                        else if (BMI < 24 && BMI >= 18.5) 
                        {
                           Console.WriteLine("體重正常");
                        }
                        else if (BMI < 28 && BMI >=24)
                        {
                           Console.WriteLine("體重過重");
                        }
                        else 
                        {
                           Console.WriteLine("體重肥胖");
                        };

                        //wcm >= 90 + (sx? 5:0 ) 高
                        //wcm >= 80 + (sx ? 5 : 0) && wcm < 90 + (sx? 5:0) 中
                        //wcm < 80+ (sx ? 5 : 0) 低
                        //BMI >= 28

                        if ( (BMI < 18.5 && wcm >= 90 + (sx? 5:0 )) || (BMI < 24 && BMI >= 18.5 && wcm >= 80 + (sx ? 5 : 0) && wcm < 90 + (sx? 5:0)) || (BMI < 28 && BMI >= 24 && wcm < 80+ (sx ? 5 : 0)) )
                        {
                            Console.WriteLine("危險");
                        }
                        else if( (BMI < 24 && BMI >= 18.5 && wcm >= 90 + (sx ? 5 : 0)) || (BMI < 28 && BMI >= 24 && wcm >= 80 + (sx ? 5 : 0) && wcm < 90 + (sx ? 5 : 0)) || (BMI >= 28 && wcm < 80 + (sx ? 5 : 0)) )
                        {
                            Console.WriteLine("高危險");
                        }
                        else if( (BMI < 28 && BMI >= 24 && wcm >= 90 + (sx ? 5 : 0)) || (BMI >= 28 && wcm >= 80 + (sx ? 5 : 0) && wcm < 90 + (sx ? 5 : 0)) )
                        {
                            Console.WriteLine("極高危險");
                        }
                        else if(BMI >= 28 && wcm >= 90 + (sx ? 5 : 0))
                        {
                            Console.WriteLine("最極高危險");
                        }
                        else
                        {
                            Console.Write("正常");
                        };
                            
                         
                    }
                }
                catch(Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n" + e.Message + "\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("\nAuto!\n");
                    System.Threading.Thread.Sleep(RD.Next(100, 1001));
                }
            }
        }
    }
}
