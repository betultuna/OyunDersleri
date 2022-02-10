using System;
using System.Collections.Generic;
using System.Threading;

namespace Usem.Programlar
{
    class MuzikCalar
    {
        static Dictionary<string, string> album = new Dictionary<string, string>();
        static Stack<string> gecmis = new Stack<string>();

        // Çalıyor : TRUE , Durdu: FALSE
        static bool durum = false;
        static bool acik = true;
        static string calanParca; // Dictionary'deki KEY

        public static void Baslat()
        {
            Console.Clear();
            AlbumOlustur();
            while (acik) // programın çalışır halde kalmasını sağlıyor
            {
                if (durum)
                {
                    GosterPanel();
                    TercihPanelDegerlendir(TercihPanel());
                    //
                }
                else
                {
                    GosterListe();
                    TercihListeDegerlendir(TercihListe());
                    //
                }
            }
            // GosterGecmis();
        }

        private static void GosterGecmis()
        {
            Console.Clear();
            System.Console.WriteLine("Çalınan parçalar");

            foreach (var item in gecmis)
            {
                album.TryGetValue(item, out string parca);
                Console.WriteLine(parca);
                System.Console.WriteLine(item + " - " + album[item]);
            }
        }

        private static void TercihListeDegerlendir(string tercih)
        {
            // Çıkış mı? Parça Seçim mi?

            //
            if (tercih == "0")
            {
                Console.WriteLine("Kapatılıyor");
                acik = false;
            }
            else
            {
                calanParca = tercih;
                DurCalGecis();
            }
        }

        private static void TercihPanelDegerlendir(string tercih)
        {
            switch (tercih)         // Çal(1)         Dur(2)    Çıkış (0)
            {
                case "0":
                    Console.WriteLine("Kapatılıyor...");
                    acik = false;
                    break;
                case "1":
                    if (durum == true)
                    {
                        System.Console.WriteLine("Zaten çalıyor...");
                        Thread.Sleep(1000);
                    }
                    DurCalGecis();
                    break;
                case "2":
                    CalDurGecis();
                    break;
            }

        }

        private static string TercihPanel()
        {
            string tercih = "";
            bool devam = true;

            while (devam)
            {
                Console.Write("Tercih? : ");
                tercih = Console.ReadLine();
                if (tercih == "1" || tercih == "2" || tercih == "0") // Paneldeki butonlar Çal(1) Dur(2)
                {
                    devam = false;
                }
                else
                {
                    Console.Clear();
                    GosterPanel();
                    Console.WriteLine("Geçersiz tercih");
                }
            }
            return tercih;
        }

        private static string TercihListe()
        {
            string tercih = "";
            bool devam = true;

            while (devam)
            {
                Console.Write("Tercih? : ");
                tercih = Console.ReadLine();
                if (album.ContainsKey(tercih) || tercih == "0")     // 0 değeri dict. key'de olmamalı!
                {
                    devam = false;
                }
                else
                {
                    Console.Clear();
                    GosterListe();
                    Console.WriteLine("Geçersiz tercih");
                }
            }
            return tercih;
        }

        private static void AlbumOlustur()
        {
            album.Add("1", "Parça 1");
            album.Add("2", "Parça 3");
            album.Add("3", "Parça 3");
            album.Add("4", "Parça 4");
            Console.WriteLine("Album Oluşturuldu.");
        }

        private static void GecmisEkle()
        {
            gecmis.Push(calanParca);
        }

        private static void CalDurGecis()
        {
            durum = false;
            Console.Clear();
        }

        private static void DurCalGecis()
        {
            durum = true;
            GecmisEkle();
            Console.Clear();
        }

        private static void GosterPanel()
        {
            System.Console.WriteLine($"Çalan parça : {calanParca}");
            Console.WriteLine(" ÇAL(1)      |      DUR(2)    |      Çıkış(0) ");
        }

        private static void GosterListe()
        {
            System.Console.WriteLine("ALBUM");
            foreach (var p in album)
            {
                System.Console.WriteLine($"Parça No : {p.Key} - Parça Adı : {p.Value} ");
            }
            System.Console.WriteLine("------");
            System.Console.WriteLine("ÇIKIŞ (0)");
        }
    }
}
