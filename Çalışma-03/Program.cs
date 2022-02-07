using System;

namespace Calisma02
{
    class Program
    {
        static void Main(string[] args)
        {





            int j = 2;
            for (int i = 1; i < 100; i = i * 2)
            {
                j = j - 1;
                while (j < 25)
                {
                    j = j + 5;
                    Console.WriteLine(j);
                }
            }




            int p = 2;
            for (int q = 0; q < 32; q = q * 2)
            {
                while (p < q)
                {
                    p = p * 2;
                    Console.WriteLine("p değeri: " + p + "\n" + "q değeri: " + q);
                }
                q = p - q;
                Console.WriteLine("p değeriii: " + p + "\n" + "q değeriii: " + q);
            }
            Console.WriteLine("p değeriiiiiiiiii: " + p + "\n" + "q değeriiiiiiiiiiiiiiiiiiiiii: ");

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
