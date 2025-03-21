using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6petla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>1). Narysuj na ekranie z gwiazdek trójkąt równoramienny, który
            //nie jest trójkątem prostokątnym. Użyj pętli for.

            int i, j, n;
            Console.Write("Podaj liczbę naturalną n>1: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++) Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++) Console.Write("*");
                Console.WriteLine("");

                    
            }

            Console.ReadKey(true);
        }
    }
}
