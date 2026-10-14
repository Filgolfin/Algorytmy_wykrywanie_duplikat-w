namespace Wykrywanie_duplikatów_w_danych_wejściowych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dlugoscTablicy = PodajDlugosc();
            int[] arr = TworzenieTablicy(dlugoscTablicy);
            PobieraniWartosci(arr);

            
        }

        static int PodajDlugosc()
        {
            int liczba;
            Console.WriteLine("Podaj długość tablicy.");

            while(!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.WriteLine("Podano nie prawidłową wartość. Spróbuj ponownie.");
            }

            return liczba;
        }

         static int[] TworzenieTablicy (int dlugosc) { 

            int[] tablica = new int[dlugosc];

            return tablica;
        }

        static void PobieraniWartosci(int[] tablica)
        {
            int element;
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine($"Podaj wartość {i+1} elementu tablicy.");
                while(!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Podano nieporawną wartość. Spróbuj ponownie");
                }

                tablica[i] = element;
            }
        }

        static void SprawdzDuplikaty(int[] tablica)
        {
            bool czyDuplikat;
            int liczbaPorownan;
        
        }
    }
}
