using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_timemoney
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int hour0, min0, hour1, min1, i;

                string[] st = Console.ReadLine().Split(' ');
                hour0 = int.Parse(st[0]);
                min0= int.Parse(st[1]);

                string[] fi = Console.ReadLine().Split(' ');
                hour1 = int.Parse(fi[0]);
                min1 = int.Parse(fi[1]);

                if ((st.Length == 2 && 0<=hour0 && hour0<24 && 0<=min0 && min0<60) && (fi.Length == 2 && 0 <= hour1 && hour1 < 24 && 0 <= min1 && min1 < 60)) 
                    //第一行:各字串都限制輸入兩個 且必須符合0<=hour<24 0<=min<60 
                {  
                    if (min1 < min0)//要進行借位並運算
                    {                 
                        hour1 --;
                        min1 += 60;

                        if (hour1 < hour0) break;

                        if((min1-min0)<30)
                        {
                            i = 0;
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                    else
                    {
                        if (hour1 < hour0) break;

                        if ((min1 - min0) < 30)
                        {
                            i = 0;
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                        if (hour1 == hour0)// 未滿半小時 已證實沒問題
                        {
                            Console.WriteLine(30 * i);
                        }
                        else if (hour1 - 2 < hour0) //半小時~未滿2小時 已證實沒問題
                        {
                            Console.WriteLine(60 * (hour1 - hour0) + 30*i);
                        }
                        else if (hour1 - 4 < hour0) //2小時~未滿4小時 已證實沒問題
                        {
                            Console.WriteLine(30 * 4 + 80 * ((hour1 - 2) - hour0) + 40*i);
                        }
                        else //超過4小時
                        {
                            Console.WriteLine(30 * 4 + 40 * 4 + 120 * ((hour1 - 4) - hour0) + 60*i);
                        }

                }
                else
                {
                    break;
                }

            }
        }
    }
}
