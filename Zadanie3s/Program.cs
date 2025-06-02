using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10; 
            string[] oceny = new string[N]; 
            int w, ile = 0; 

            do
            {
                Console.WriteLine("\nMENU:\n1-dodaj\n2-modyfikuj\n3-usuń\n4-wyświetl\n5-zakończ");
                Console.Write("Wybierz: ");
                w = Convert.ToInt32(Console.ReadLine());

                switch (w)
                {
                    case 1: 
                        if (ile < N)
                        {
                            Console.Write("Podaj nazwę oceny: ");
                            oceny[ile] = Console.ReadLine();
                            ile++;
                        }
                        else Console.WriteLine("Brak miejsca!!!");
                        break;

                    case 2: 
                        if (ile > 0)
                        {
                            Console.Write("Podaj numer oceny do modyfikacji: ");
                            int nr = Convert.ToInt32(Console.ReadLine());
                            if (nr > 0 && nr <= ile)
                            {
                                Console.Write("Nowa nazwa oceny ({0}): ", oceny[nr - 1]);
                                oceny[nr - 1] = Console.ReadLine();
                            }
                            else Console.WriteLine("Błędny numer !!!");
                        }
                        else Console.WriteLine("Brak elementów !!!");
                        break;

                    case 3: 
                        if (ile == 0) Console.WriteLine("Brak elementów !!!");
                        else
                        {
                            Console.Write("Podaj numer oceny do usunięcia: ");
                            int nr = Convert.ToInt32(Console.ReadLine());
                            if (nr > 0 && nr <= ile)
                            {
                                Console.WriteLine("Usunięty został: {0}", oceny[nr - 1]);
                                if (ile == 1) ile = 0;
                                else
                                {
                                    for (int i = nr - 1; i < ile - 1; i++)
                                        oceny[i] = oceny[i + 1];
                                    ile--;
                                }
                            }
                            else Console.WriteLine("Błędny numer !!!");
                        }
                        break;

                    case 4: 
                        Console.WriteLine("Lista ocen:");
                        for (int i = 0; i < ile; i++)
                            Console.WriteLine("{0}) {1}", i + 1, oceny[i]);
                        break;

                    default:
                        Console.WriteLine("Nieznany wybór !!!");
                        break;
                }
            }
            while (w != 5);

            Console.ReadKey(true); 
        }
    }
}