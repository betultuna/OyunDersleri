using System;

namespace Calisma02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 5, 7, 12, 9 };
            string[] sDizi = { "test", "fest", "mest", "kest" };
             foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("-------------------------------");

            Array.Clear(dizi,1,3);

            Console.WriteLine("-------------------------------");

            foreach (int sayi in dizi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
