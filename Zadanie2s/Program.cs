using System;

namespace ConsoleApplication1
{
    
    struct Uczen
    {
        public string imie, nazwisko;
        public byte[] oceny;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Uczen[] uczniowie; 
            int ilu_uczniow, ile_ocen, i, j; 

            
            Console.Write("Podaj liczbę uczniów w klasie: ");
            ilu_uczniow = Convert.ToInt32(Console.ReadLine());

            
            uczniowie = new Uczen[ilu_uczniow];

            
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("Podaj imię ucznia ({0}): ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj nazwisko ucznia ({0}): ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();

               
                Console.Write("Ile ocen ma uczeń ({0}): ", uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());

                
                uczniowie[i].oceny = new byte[ile_ocen];

                
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.Write("Podaj ocenę numer ({0}): ", j + 1);
                    uczniowie[i].oceny[j] = Convert.ToByte(Console.ReadLine());
                }
            }

           
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("{0} {1}: ", uczniowie[i].imie, uczniowie[i].nazwisko);
                for (j = 0; j < uczniowie[i].oceny.Length; j++)
                {
                    Console.Write("{0} ", uczniowie[i].oceny[j]);
                }
                Console.WriteLine(); 
            }

            Console.ReadKey(true); 
        }
    }
}