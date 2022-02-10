using System;
using System.Collections.Generic;

namespace Usem.Oyunlar
{
    class ZarOyun
    {
        static private int toplamPuan;
        static private int kazanmaSinirPuan = 15;
        static private int atisSayisi = 3; // değiştirirsen ekstra değerlendirmeyi değiştir

        static public void ProgramBaslat()
        {
            Oyna();
            Final();
        }

        private static void Oyna()
        {
            Random zar = new Random();
            List<int> atislar = new List<int>();

            int atis;
            for (int i = 0; i < atisSayisi; i++)
            {
                atis = zar.Next(1, 7);
                atislar.Add(atis);
                System.Console.Write($" | {i + 1}.Atış {atis}");
            }
            System.Console.WriteLine();

            int toplam = 0;
            foreach (var a in atislar)
            {
                toplam += a;
            }

            int ekstra = EkstraDegerlendir(atislar);
            toplamPuan = toplam + ekstra;
            Console.WriteLine("Puan : " + toplamPuan);
        }

        private static void Final()
        {
            if (toplamPuan > kazanmaSinirPuan)
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

        private static int EkstraDegerlendir(List<int> atisListe)
        {
            int z1 = atisListe[0];
            int z2 = atisListe[1];
            int z3 = atisListe[2];

            int ekstraPuan = 0;
            // üç zar aynı ise 6
            // a = b VE b = c >>>  a = c
            // üç zar aynı değilse
            // iki zar aynı ise 2
            // a = b  VEYA  a = c VEYA   b = c
            // 
            if (z1 == z2 && z2 == z3)
            {
                // 3 aynı var
                ekstraPuan += 6;

            }
            else if (z1 == z2 || z1 == z3 || z2 == z3)
            {
                // 2 aynı var
                ekstraPuan += 2;
            }
            else
            {
                // yok
                System.Console.WriteLine("Ekstra puan yok");
            }
            return ekstraPuan;
        }

    }
}
