using System;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            int koniec;
            try
            {
                do
                {
                    Console.WriteLine("Podaj liczbe dla której ma być obliczona silnia: ");
                    int liczba = int.Parse(Console.ReadLine());

                    int wynik = Silnia(liczba);
                    Console.WriteLine("Silnia podanej liczby wynosi: " + wynik);

                    Console.WriteLine("Aby zakończyć program wybierz '0', jeżeli chcesz kontynuować wybierz dowolną cyfrę");
                    koniec = int.Parse(Console.ReadLine());

                } while (koniec != 0);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        private static int Silnia (int licz) 
        { 
            if (licz < 1)
            {
                return 1;
            }
            else
            {
                return licz *= Silnia (licz - 1);
            }

        }
    }
}
