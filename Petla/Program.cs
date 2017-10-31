using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petla
{
    class Program
    {
        static void Main(string[] args)
        {
            Petla p = new Petla() { A = 10 };

            Console.WriteLine("Silnia z " + p.A + " = " + p.Silnia());

            Console.WriteLine("Ciąg Fibonacciego do liczby " + p.A + ":");
            p.LiczbyFibonacciego();

            Console.ReadKey();
        }
    }
}
