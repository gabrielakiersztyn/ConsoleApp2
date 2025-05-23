using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2m
{
    class Program
    {
        static double max(double x, double y)
        {
            if (x > y) return x;
            else return y;
        }
        static void Main(string[]args)
        {
            Console.WriteLine("Max z 3 i 8 to {0}", max(3, 8));
            Console.WriteLine("Max z 8 i 3 to {0}", max(8, 3));
            Console.WriteLine("Max z 3 i 3 to {0}", max(3, 3));
            Console.ReadKey(true);
        }
    }
}
