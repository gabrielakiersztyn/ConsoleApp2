using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6m
{
    class Program
    {
        static void kwadrat(int a, char znak1, char znak2)

        {
            int i, j;
            for (i = 1; i <= a; i++) Console.Write(znak1);
            Console.WriteLine("");
            for (i =2; i <= a -1; i++)
            {
                Console.Write(znak1);
                for(j=2; j<=a-1; j++) Console nsole.Write(znak2);
                Console.Write(znak1);
                Console.WriteLine("");


            }
            for (i = 1; i <= a; i++) Console.WriteLine(znak1);
                
        }
        static void Main(string[] args)
        {
            kwadrat(6, '#', '*');
            Console.ReadKey(true);

        }
    }
}
