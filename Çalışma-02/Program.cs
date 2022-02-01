using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static void Main()
        {
            string deger;
            string sonDeger;

            deger = Giris();                 // string geliyor
            sonDeger = Proses(deger);        // string bekliyor, string veriyor
            Cikis(sonDeger);                 // string bekliyor
        }

        static string Giris()
        {
            string girisM;
            // Giriş İşlemleri
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

