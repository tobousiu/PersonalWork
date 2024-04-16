using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS_Q2
{
    internal class Program
    {
        static Thread MA, MB, MC;
        static Random rd = new Random();
        static int time;
        static void Main(string[] args)
        {
        while(true)
            {
                try
                {
                    Console.WriteLine("Multithreading：3 Lotto Machines and 7 LottoCodes[0-9]");
                    Console.Write("Max. time of generated one Lotto Code(ms)？");
                    string x=Console.ReadLine();
                    time=int.Parse(x);

                    MA = new Thread(new ThreadStart(LMA));
                    MB = new Thread(new ThreadStart(LMB));
                    MC = new Thread(new ThreadStart(LMC));
                    MA.Start();
                    MB.Start();
                    MC.Start();
                    Console.ReadKey();
                }
                catch(Exception e)
                { 
                    Console.WriteLine(e.ToString()); 
                }
            }
                
        }

        static void LMA()
        {
            int[] lotte = new int[8];
            string str = "";
            int con = 1;
            bool sth;
            while(con<=7)
            {
                System.Threading.Thread.Sleep(rd.Next(1, time));
                sth = true;
                Console.Write("Lotte1:");
                lotte[con] = rd.Next(0,10);
                str += lotte[con];
                for(int i=1;i<con;i++)
                {
                    if(lotte[i]==lotte[con])
                    {
                        sth = false;
                        break;
                    }
                }
                if(sth==false)
                {
                    str += "*  ";
                    Console.WriteLine(str);
                    continue;
                }
                str += "  ";
                Console.WriteLine(str);
                con++;

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n======================================================");
            Console.Write($"[Finish]---Lotto1：");
            for(int i=1;i<8;i++)
            {
                Console.Write($"{lotte[i]}  ");
            }
            Console.WriteLine("\n======================================================\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            MA.Abort();

        }
        
        static void LMB()
        {
            int[] lotte = new int[8];
            string str = "";
            int con = 1;
            bool sth;
            while (con <= 7)
            {
                System.Threading.Thread.Sleep(rd.Next(1,time));
                sth = true;
                Console.Write("Lotte2:");
                lotte[con] = rd.Next(0, 10);
                str += lotte[con];
                for (int i = 1; i < con; i++)
                {
                    if (lotte[i] == lotte[con])
                    {
                        sth = false;
                        break;
                    }
                }
                if (sth == false)
                {
                    str += "*  ";
                    Console.WriteLine(str);
                    continue;
                }
                str += "  ";
                Console.WriteLine(str);
                con++;

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n======================================================");
            Console.Write($"[Finish]---Lotto2：");
            for (int i = 1; i < 8; i++)
            {
                Console.Write($"{lotte[i]}  ");
            }
            Console.WriteLine("\n======================================================\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            MB.Abort();
        }

        static void LMC()
        {
            int[] lotte = new int[8];
            string str = "";
            int con = 1;
            bool sth;
            while (con <= 7)
            {
                System.Threading.Thread.Sleep(rd.Next(1, time));
                sth = true;
                Console.Write("Lotte3:");
                lotte[con] = rd.Next(0, 10);
                str += lotte[con];
                for (int i = 1; i < con; i++)
                {
                    if (lotte[i] == lotte[con])
                    {
                        sth = false;
                        break;
                    }
                }
                if (sth == false)
                {
                    str += "*  ";
                    Console.WriteLine(str);
                    continue;
                }
                str += "  ";
                Console.WriteLine(str);
                con++;

            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\n======================================================");
            Console.Write($"[Finish]---Lotto3：");
            for (int i = 1; i < 8; i++)
            {
                Console.Write($"{lotte[i]}  ");
            }
            Console.WriteLine("\n======================================================\n\n");
            Console.ForegroundColor = ConsoleColor.White;
            MC.Abort();
        }
    }
}
