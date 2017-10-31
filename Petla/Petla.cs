using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petla
{
    public class Petla
    {
        public int A { get; set; }
        public long Silnia()
        {
            long silnia = 1;
            for (int i = 1; i <= A; i++)
                silnia = silnia * i;
            return silnia;
        }
        public void LiczbyFibonacciego()
        {
            long fib1 = 0;
            long fib2 = 0;
            long i = 0;
            while (i <= A) {
                if (i == 0)
                    Console.WriteLine(0);
                else
                {
                    if (i == 0)
                    {
                        Console.WriteLine(1);
                        fib2 = 1;
                    }
                    else
                    {
                        Console.WriteLine(fib1 + fib2);
                        long fib = fib1;
                        fib1 = fib2;
                        fib2 = fib + fib2;
                        if (fib2 == 0)
                            fib2 = 1;
                    }
                }
                i++;
            }
        }
    }
}
