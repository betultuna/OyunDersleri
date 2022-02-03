using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static void Main()
        {
            string deger;
            string sonDeger;

            // Giriş
            deger = Giris();

            // İşlemler
            sonDeger = Proses(deger);

            // Çıkış işlemler
            Cikis(sonDeger);
        }

        static string Giris()
        {
            string girisM;
            // Giriş işlemleri
            Console.WriteLine("Giriş Yapınız...");
            girisM = Console.ReadLine();

            if (Gecerli(girisM))
                return girisM;
            return "TEST";
        }


        static bool Gecerli(string metin)
        {
            bool gecerli = true;

            // uzunluk hesaplama
            int uzunluk = metin.Length;

            // uzunluk değerlendirme
            if (uzunluk > 3)
            {
                // koşul TRUE doğru ise çalıştırılır
                gecerli = true;
            }
            else
            {
                // koşul FALSE yanlış ise çalıştırılır
                gecerli = false;
            }
            return gecerli;
        }



        static string Proses(string g)
        {
            // String işlemler
            string cikisM;
            cikisM = "Giriş :  " + g;
            return cikisM;

        }

        static void Cikis(string c)
        {
            // Çıkış İşlemler
            Console.WriteLine(c);
        }
    }
}

