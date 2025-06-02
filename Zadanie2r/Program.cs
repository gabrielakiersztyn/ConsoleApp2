using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2r
{
    class Program
    {
        static long fib(long n)

        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return fib(n - 1) + fib(n - 2);
        }
        
        stativ void Main(string[] args)
        {
            Console.Write("Podaj n=");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.WriteLine("Błędny parametr");
            else Console.WriteLine("Fib({0})={1}", n, fib(n));
            Console.ReadKey(true);
        }

    }
}
