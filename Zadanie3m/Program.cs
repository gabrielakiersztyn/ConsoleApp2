using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3m
{
    class Program
    {
        static double pole_kola(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dla r=1,5 Pole={0}", pole_kola(1.5));
            Console.ReadKey(true);

        }
    }
}
