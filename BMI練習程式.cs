using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    checked
                    {
                        Console.Write("方案A(自動) or 方案B(輸入)?");
                        double BMI;
                        double g;
                        double m;
                        Random RD = new Random();
                        string wh = Console.ReadLine();


                        switch (wh)
                        {
                            case "A":

                                g = 10 * RD.NextDouble();
                                m = 10 * RD.NextDouble();
                                Console.WriteLine("input: g=" + Math.Round(g, 1) + " m=" + Math.Round(m, 2));

                                BMI = g / Math.Pow(m, 2);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("BMI=" + Math.Round(BMI, 2));
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                                System.Threading.Thread.Sleep(RD.Next(100, 2001));
                                break;

                            case "B":
                                Console.Write("g=? m=?");
                                string[] x=Console.ReadLine().Split(' ');

                                g = double.Parse(x[0]);
                                m = double.Parse(x[1]);
                                BMI= g / Math.Pow(m, 2);

                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("BMI=" + Math.Round(BMI, 2));
                                Console.ForegroundColor = ConsoleColor.Gray;
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;

                            default:
                                return;
                        }
                    }    

                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally
                {
                    Console.WriteLine("again!\n");
                }



            }
             
        }
    }
}
