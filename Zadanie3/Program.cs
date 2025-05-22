using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {//Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych, sortujący je niemalejąco i
            //wypisujący posortowane liczby na ekranie.
            int[] tab = new int[1000];
            int i, j;
            int n, tmp;
            Console.Write("Podaj ilość elementów tablicy n<=1000: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=0; i < n; i++)
            {
                Console.Write("Podaj tab[{0}]= ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i=0; i < n; i++)
                for (j = i+1; j<n; j++)
                    if (tab[i] > tab[j])
                    { tmp = tab[i]; tab[i] = tab[j]; tab[j] = tmp; }
            Console.Write("Elementy tablicy: ");
            for (i=0; i < n; i++)
            {
                Console.Write("{0}, ", tab[i]);

            }
            Console.ReadKey(true);

        }
    }
}
