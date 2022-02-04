using System;

namespace Calisma02
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;

            for (int i = 0; true; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.WriteLine("Sonlandı");
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