using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CStrain_4_1
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
                    Console.WriteLine("Tip: 僅限(+-*/%)，清除：C");
                    Console.WriteLine("=========================");
                    Console.WriteLine(ans);
                    Console.WriteLine("=========================");
                    
                    string[] x = Console.ReadLine().Split(' ');
                    decimal ans1, num;
                    if(x[0] == "C")
                    {
                        ans = 0;
                        continue;
                    }
                    num = decimal.Parse(x[1]);
                    ans1 = ans;

                    checked 
                    {
                        switch(x[0])
                        {
                            case "+":
                                ans += num;
                                break;

                            case "-":
                                ans -= num;
                                break;

                            case "*":
                                ans *= num;
                                break;

                            case "/":
                                ans /= num;
                                break;

                            case "%":
                                ans %= num;
                                break;

                        } 
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(ans1 + " " + x[0] + " " + x[1] + " = " + ans);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
