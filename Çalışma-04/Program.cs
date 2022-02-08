using System;
using System.Collections;
using System.Collections.Generic;

namespace Calisma02
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] dizi = { 5, 7, 12, 9 };

            // List<T> isimListe = new List<T>();
            // List<int> diziListe = new List<int>();
            // List<string> diziListeString = new List<string>();

            // diziListe.Add(5);
            // diziListe.Add(7);
            // diziListe.Add(12);
            // diziListe.Add(9);

            // string[] sDizi = { "test", "fest", "mest", "kest" };
            // diziListeString.Add("test");
            // diziListeString.Add("fest");
            // diziListeString.Add("mest");
            // diziListeString.Add("kest");

            // Stack<int> yiginSayi = new Stack<int>();
            // yiginSayi.Push(50);
            // yiginSayi.Push(15);
            // yiginSayi.Push(25);
            // yiginSayi.Push(5);

            // Queue<int> kuyrukSayi = new Queue<int>();
            // kuyrukSayi.Enqueue(50);
            // kuyrukSayi.Enqueue(15);
            // kuyrukSayi.Enqueue(25);
            // kuyrukSayi.Enqueue(5);

            // int kuyruktanGelen = kuyrukSayi.Dequeue();


            // Dictionary<string, string> sozlukKelimeler = new Dictionary<string, string>();
            // sozlukKelimeler.Add("34", "istanbul");
            // sozlukKelimeler.Add("55", "samsun");
            // sozlukKelimeler.Add("06", "ankara");

            ArrayList aList = new ArrayList();
            object o = 3;

            aList.Add(1);
            aList.Add("Test");
            aList.Add(true);

            foreach (var eleman in aList)
            {
                Console.WriteLine(eleman);
            }



        }
    }
}


// bool devam = true;

// while (devam) // bool değeri ile kontrol ediliyor. 
// {
//     // Console.Clear();
//     // Console.WriteLine("1");
//     // Console.WriteLine("MENU : Devam?");
//     // Console.WriteLine("===============");

//     string giris = Console.ReadLine();
//     if (giris == "h")
//     {
//         devam = false;
//     }
// }


// Doğru döngüyü seçmek​
// While		: yineleme sayısını tam olarak bilmiyorsan​
// Do While	    : yineleme sayısını tam olarak bilmiyorsan ama en az bir kez işlem yapılsın istiyorsan​
// For			: yineleme sayısını tam olarak biliyorsun​
// For Each	    : bir koleksiyonda yer alan her bir eleman için işlem yapmak istiyorsan​
