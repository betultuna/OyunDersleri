using System;
namespace Usem.Calisma01
{
    class OzelProgram
    {
        static string ortadaDeger;
        static void Main()
        {
            // Giriş
            Giris();
            // İşlemler
            Proses();
            // Çıkış işlemler
            Cikis();
        }

        static void Giris()
        {
            // string girisM;
            // Giriş işlemleri
            Console.WriteLine("Giriş Yapınız...");
            ortadaDeger = Console.ReadLine();

            ortadaDeger = Gecerli() ? "\""+ ortadaDeger+"\" ifadesi geçerlidir." : "Hata verildi";
            

            // alternatif if
            // if (Gecerli())
            // {
            //     ortadaDeger = "\""+ ortadaDeger+"\" ifadesi geçerlidir.";
            // }
            // else
            // {
            //     ortadaDeger = "Hata verildi";
            // }
        }

        static bool Gecerli()
        {
            bool gecerli = true;

            // uzunluk hesaplama
            int uzunluk = ortadaDeger.Length;

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

        static void Proses()
        {
            // String işlemler
            ortadaDeger = "Giriş :  " + ortadaDeger;
        }

        static void Cikis()
        {
            // Çıkış İşlemler
            Console.WriteLine(ortadaDeger);
        }
    }
}

