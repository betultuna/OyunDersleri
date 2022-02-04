using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            int oyunSonuc = Oyna();
            Final(oyunSonuc);
            Deneme();
        }

        private static void Deneme()
        {
            throw new NotImplementedException();
        }

        private static int Oyna()
        {
            Random zar = new Random();
            // Zarlar atılıyor
            int atis1 = zar.Next(1, 7);
            int atis2 = zar.Next(1, 7);
            int atis3 = zar.Next(1, 7);
            int toplam = atis1 + atis2 + atis3;
            int ekstra = EkstraDegerlendir(atis1, atis2, atis3);
            int puan = toplam + ekstra;
            Console.WriteLine("Puan : " + puan);
            return puan;
        }
        private static void Final(int p)
        {
            if (p > 15)
            {
                // Kazanma koşulu
                Console.WriteLine("Kazandın");
            }
            else
            {
                // Kaybettin...
                Console.WriteLine("Kaybettin...");
            }

        }

        private static int EkstraDegerlendir(int z1, int z2, int z3)
        {
            int degisken;
            // üç zar aynı ise 6
            // a = b VE b = c >>>  a = c
            // üç zar aynı değilse
            // iki zar aynı ise 2
            // a = b  VEYA  a = c VEYA   b = c
            // 
            if (z1 == z2 && z2 == z3)
            {
                // 3 aynı var
                degisken = 6;
            }
            else if (z1 == z2 || z1 == z3 || z2 == z3)
            {
                // 2 aynı var
                degisken = 2;
            }
            else
            {
                // yok
                degisken = 0;
            }
            return degisken;
        }

    }
}
