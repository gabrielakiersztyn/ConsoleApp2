using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4petla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt
            //posiadający n wierszy i k kolumn. Użyj pętli for.
            int i, j, n, k;
            Console.Write("Podaj liczbę naturalną n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę naturalną k: ");
            k = Convert.ToInt32(Console.ReadLine());

            for ( i = 1; i <= n; i++)
            {
                for (j = 1; j <= k; j++)
                    Console.Write("*");
                Console.WriteLine("");

            }
            Console.ReadKey(true);

        }
    }
}
