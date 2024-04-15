using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_4
{
    class Program
    {
        static void Main(string[] args)
        {                    
            decimal ans = 0;

            while(true)
            {
                try 
                {
                    decimal ans1;
                    Console.WriteLine("Tip: 僅限(+-*/%)，清除：C");
                    Console.WriteLine("=========================");
                    Console.WriteLine(ans);
                    Console.WriteLine("=========================");

                    String[] x = Console.ReadLine().Split(' ');
                    //if (x.Length != 2) continue;

                    checked 
                    {
                        switch (x[0]) 
                        {
                            case "+":
                                ans1 = ans + decimal.Parse(x[1]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(ans + " " + x[0] + " "+x[1] + "= " + ans1);
                                Console.ForegroundColor = ConsoleColor.White;

                                ans += decimal.Parse(x[1]);
                                break;

                            case "-":
                                ans1 = ans - decimal.Parse(x[1]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(ans + " " + x[0] + " "+ x[1] + "= " + ans1);
                                Console.ForegroundColor = ConsoleColor.White;

                                ans -= decimal.Parse(x[1]);
                                break;

                            case "*":
                                ans1 = ans * decimal.Parse(x[1]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(ans + " " + x[0] + " "+ x[1] + "= " + ans1);
                                Console.ForegroundColor = ConsoleColor.White;

                                ans *= decimal.Parse(x[1]);
                                break;

                            case "/":
                                ans1 = ans / decimal.Parse(x[1]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(ans + " " + x[0] + " "+ x[1] + "= " + ans1);
                                Console.ForegroundColor = ConsoleColor.White;

                                ans /= decimal.Parse(x[1]);
                                break;

                            case "%":
                                ans1 = ans % decimal.Parse(x[1]);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(ans + " " + x[0] + " "+ x[1] + "= " + ans1);
                                Console.ForegroundColor = ConsoleColor.White;

                                ans %= decimal.Parse(x[1]);
                                break;

                            case "C":
                                ans = 0;
                                break;
                                


                        }
                    }
                }
                catch(Exception e) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                finally 
                {
                }

            }
        }
    }
}
