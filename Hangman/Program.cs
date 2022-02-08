// Özellik : Kullanıcı tüm kelimeyi tahmin edebilsin.
// Özellik : Tahmin edilmiş harflerin gösterilmesi. 
// Özellik : ipucu vermek

using System;

namespace Hangman
{
    class Program
    {
        static string oynananKelime = "araba";
        static char tahmin;
        static bool kalanHarfVar = true;

        // tahmin değerlendirme veri yapısı
        static char[] maskeliDizi = new char[oynananKelime.Length];

        static void Main(string[] args)
        {
            //
            ProgramBaslat();

            //
            OyunOyna();

            //
            ProgramBitir();
        }

        private static void OyunOyna()
        {
            Console.WriteLine("Oyun başladı");
            // Kelime göster (parametrik, hangi harflerin gösterileceği liste olarak verilebilir)
            KelimeGoster();

            while (kalanHarfVar)
            {
                // Kullanıcıdan tahmin al
                TahminAl();

                // Tahmini değerlendir
                TahminDegerlendir();

                // Tahmin sonrası kelime gösterme
                KelimeGoster();
            }


        }


        private static void TahminDegerlendir()
        {
            // veri yapıları
            char[] kelimeDizi = oynananKelime.ToCharArray(); // a,r,a,b,a

            int uzunluk = oynananKelime.Length;
            int kalanHarfSayisi = uzunluk;
            //
            for (int i = 0; i < uzunluk; i++)
            {
                if (tahmin == kelimeDizi[i])
                {
                    maskeliDizi[i] = tahmin;
                    kalanHarfSayisi -= 1;
                }
            }

            // Değerlendirme bitti
            kalanHarfVar = kalanHarfSayisi == 0 ? false : true;
            // if (kalanHarfSayisi == 0) {
            //     kalanHarfVar = false;
            // }

            Console.WriteLine("Tahmin degerlendirildi..");
        }

        private static void TahminAl()
        {
            // tahmin = 'a';
            //ConsoleKeyInfo cKey = Console.ReadKey();
            //tahmin = cKey.KeyChar;
            string giris;
            bool girisAlindi = false; // flag bayrak

            while (!girisAlindi)
            {
                giris = Console.ReadLine();
                if (giris.Length > 0)
                {
                    tahmin = giris[0];
                    Console.WriteLine("Tahmin edilen harf : " + tahmin);
                    girisAlindi = true;
                }
                else
                {
                    Console.WriteLine("Harf girmediniz!...");
                }
            }
        }

        private static void KelimeGoster()
        {
            Console.WriteLine(maskeliDizi);

            // foreach (var item in maskeliDizi)
            // {
            //     Console.Write(item);
            // }
            // Console.WriteLine(); // imleç başa gelsin diye.... 
        }

        private static void ProgramBaslat()
        {
            Console.WriteLine("Program basladı");
            oynananKelime = "araba";

            // Maskeli dizi başlangıç durumu
            for (int i = 0; i < oynananKelime.Length; i++)
            {
                maskeliDizi[i] = '_';
            }
        }

        private static void ProgramBitir()
        {
            Console.WriteLine("Program bitti.");
        }

    }
}
