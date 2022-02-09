// Özellik : Kullanıcı tüm kelimeyi tahmin edebilsin.
// Özellik : Tahmin edilmiş harflerin gösterilmesi. 
// Özellik : ipucu vermek

using System;

namespace Usem.Oyunlar
{
    class KelimeTahmin
    {
        static char tahmin;
        static bool kalanHarfVar;
        static int kalanHarfSayisi;

        // tahmin değerlendirme veri yapısı
        public static char[] maskeliDizi;
        public static string oynanacakKelime;

        public static void OyunAkis()
        {
            //
            ProgramBaslat();

            //
            OyunOyna();

            //
            ProgramBitir();
        }

        public static void OyunOyna()
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

        public static void TahminDegerlendir()
        {
            // veri yapıları
            char[] kelimeDizi = oynanacakKelime.ToCharArray(); // a,r,a,b,a

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

        public static void TahminAl()
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

        public static void KelimeGoster()
        {
            Console.WriteLine(maskeliDizi);

            // foreach (var item in maskeliDizi)
            // {
            //     Console.Write(item);
            // }
            // Console.WriteLine(); // imleç başa gelsin diye.... 
        }

        public static void ProgramBaslat()
        {
            // Console.WriteLine("Program basladı"); Geliştirme
            kalanHarfSayisi = oynanacakKelime.Length;
            kalanHarfVar = oynanacakKelime.Length > 0 ? true : false;


            // Maskeli dizi hazırlama -  başlangıç durumu
            maskeliDizi = new char[oynanacakKelime.Length];
            for (int i = 0; i < oynanacakKelime.Length; i++)
            {
                maskeliDizi[i] = '_';
            }
        }

        public static void ProgramBitir()
        {
            Console.WriteLine($" Kelime Bulundu: {oynanacakKelime} \nProgram bitti.");
        }

    }

    class OyunlarProgram
    {
        static void Main()
        {
            // Kelime Tahmin oyunu oynat
            Console.WriteLine("Oyun oynanacak...");
            KelimeTahmin.oynanacakKelime = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Black;
            KelimeTahmin.OyunAkis();

        }

    }
}
