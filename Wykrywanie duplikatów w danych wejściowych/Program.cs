namespace Wykrywanie_duplikatów_w_danych_wejściowych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dlugoscTablicy = PodajDlugosc();
            int[] arr = TworzenieTablicy(dlugoscTablicy);
            PobieraniWartosci(arr);
            SprawdzDuplikaty(arr);


        }

        static int PodajDlugosc()
        {
            int liczba;
            Console.WriteLine("Podaj długość tablicy.");

            while (!int.TryParse(Console.ReadLine(), out liczba))
            {
                Console.WriteLine("Podano nie prawidłową wartość. Spróbuj ponownie.");
            }

            return liczba;
        }

        static int[] TworzenieTablicy(int dlugosc)
        {

            int[] tablica = new int[dlugosc];

            return tablica;
        }

        static void PobieraniWartosci(int[] tablica)
        {
            int element;
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine($"Podaj wartość {i + 1} elementu tablicy.");
                while (!int.TryParse(Console.ReadLine(), out element))
                {
                    Console.WriteLine("Podano nieporawną wartość. Spróbuj ponownie");
                }

                tablica[i] = element;
            }
        }

        static void SprawdzDuplikaty(int[] tablica)
        {
            bool czyDuplikat = false;
            int liczbaPorownan = 0;

            for (int i = 0; i < tablica.Length -1; i++)
            {
                for (int j = i + 1; j < tablica.Length; j++)
                {
                    if (tablica[i] == tablica[j])
                    {
                        czyDuplikat = true;
                    }
                    liczbaPorownan++;
                }
            }

            if (czyDuplikat)
            {
                Console.WriteLine("Tablica zawiera duplikaty");
            }
            else
            {
                Console.WriteLine("Tablica nie zawiera duplikatów");
                }
            Console.WriteLine($"Liczba porównań wynosi {liczbaPorownan}");
            Console.WriteLine("Złożoność czasowa wynosi: O(n^2)");

        }
    }
}
