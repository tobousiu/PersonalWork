using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSQ3
{
    internal class Eratostosnes
    {
        public int[] PrimeNo = new int[100001];

        public void create()
        {
            PrimeNo[1] = 2; PrimeNo[2] = 3; PrimeNo[3] = 5; PrimeNo[4] = 7;
            int N = 11;
            int np, SqaueRoot;
            //  Console.WriteLine("P1 = 2\nP2 = 3\nP3 = 5\nP4 = 7");

            for (int n = 5; n <= 100000; n++)
            {
                SqaueRoot = (int)Math.Sqrt(N) + 2;
                np = 1;
                while (SqaueRoot >= PrimeNo[np])
                {
                    if (N % PrimeNo[np] == 0)
                    {
                        N++;
                        np = 1;
                    }
                    else np++;
                }
                PrimeNo[n] = N;
                // Console.WriteLine($"P{n} = {PrimeNo[n]}");
                N++;
            }
        }

        public bool text(long N)
        {
            int ptr = 1;
            if (N < 2) return false;
            else if (N == 2) return true;
            else if (N % 2 == 0) return false;
            else
            {
                //long SRoot = (long)Math.Sqrt(N)+1;
                //while(SRoot >= PrimeNo[ptr])
                while (N >= PrimeNo[ptr] * (long)PrimeNo[ptr])
                {
                    if (N % PrimeNo[ptr] == 0) return false;
                    else ptr++;
                }
                return true;
            }

        }
    }
}
