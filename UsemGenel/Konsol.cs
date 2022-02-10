
using System;

namespace Usem.Yardimcilar
{
    class Konsol
    {
        public static void KonsolLog(string kod, string mesaj)
        {
            Console.ResetColor();

            switch (kod)
            {
                case "info":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "hata":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "uyari":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }
            
            Console.WriteLine(mesaj);
            Console.ResetColor();
        }
    }
}