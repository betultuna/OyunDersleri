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
            deger = Giris();                 // string geliyor

            //İşlemler
            sonDeger = Proses(deger);        // string bekliyor, string veriyor

            //Çıkış İşlemleri
            Cikis(sonDeger);                 // string bekliyor
        }


        static string Giris()
        {
            // Giriş İşlemleri
            string girisM;
            Console.WriteLine("Giriş Yapınız...");
            girisM = Console.ReadLine();
            return girisM;
        }

        static string Proses(string g)
        {
            // String İşlemleri
            string cikisM;
            cikisM = "Giriş :  " + g;
            return cikisM;
        }


        static void Cikis(string c)
        {
            Console.WriteLine(c);
        }

    }
}

