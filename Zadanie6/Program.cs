using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach.

            string[] dni = new string[] { "Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela" };
            foreach (string elem in dni)
                Console.Write("{0}, ", elem);
            Console.ReadKey(true);
        }
    }
}
