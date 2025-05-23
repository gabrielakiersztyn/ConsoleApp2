using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4m
{
    class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba 0 ma {0} cyfrę", ile_cyfr(0));
            Console.WriteLine("Liczba 1234 ma {0} cyfry", ile_cyfr(1234));
            Console.ReadKey(true);
        }
    }
}
