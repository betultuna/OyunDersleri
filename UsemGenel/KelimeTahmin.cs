// Özellik : Kullanıcı tüm kelimeyi tahmin edebilsin.
// Özellik : Tahmin edilmiş harflerin gösterilmesi. 
// Özellik : ipucu vermek

using System;

namespace Usem.Oyunlar
{
    class KelimeTahmin
    {
        public static string oynanacakKelime;
        static string oynananKelime;
        static char tahmin;
        static bool kalanHarfVar;
        static int kalanHarfSayisi;

        // tahmin değerlendirme veri yapısı
        static char[] maskeliDizi;

        public static void OyunAkis()
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
            // Console.WriteLine("Oyun başladı"); Geliştirme 
            // Kelime göster (parametrik, hangi harflerin gösterileceği liste olarak verilebilir)
            // KelimeGoster(); // _ _ _ _ _ _ 

            while (kalanHarfVar)
            {
                // Temizle
                //Console.Clear();

                // Başlangıç ve tahmin sonrası kelime gösterme
                KelimeGoster();

                // Kullanıcıdan tahmin al
                TahminAl();

                // Tahmini değerlendir
                TahminDegerlendir();

            }


        }

        private static void TahminDegerlendir()
        {
            // veri yapıları
            char[] kelimeDizi = oynananKelime.ToCharArray(); // a,r,a,b,a

            // kelime içinde bulur maskeli dizide işaretler
            for (int i = 0; i < kelimeDizi.Length; i++)
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
            // Console.WriteLine("Program basladı"); Geliştirme
            System.Console.WriteLine("Kelime: " + oynananKelime);
            oynananKelime = "araba";
            System.Console.WriteLine("Kelime: " + oynananKelime);
            kalanHarfSayisi = oynananKelime.Length;
            kalanHarfVar = oynananKelime.Length > 0 ? true : false;


            // Maskeli dizi hazırlama -  başlangıç durumu
            maskeliDizi = new char[oynananKelime.Length];
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