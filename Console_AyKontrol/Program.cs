using System;

namespace Console_AyKontrol
{
   
    class Program
    {
        public static string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs", "Haziran", "Temmuz", "Ağustos", "Eylül", "Ekim", "Kasım", "Aralık" };

        static void Main(string[] args)
        {
            Console.WriteLine("Bir yılda kaç AY vardır?:");
            int yil = int.Parse(Console.ReadLine() ?? string.Empty);
            if (yil == 12)
            {
                for (int ay = 0; ay < 12; ay++)
                {
                    Console.WriteLine(ay+1 + ". Ay Hangisidir?:");
                    string veri = Console.ReadLine();
                    if (veri != null && aylar[ay].ToUpper() != veri.ToUpper())
                    {
                        Console.WriteLine("Hatalı Bilgi!!!!");
                        //Açıklama gereksiz ama olsun.
                    }
                    else
                    {
                        Console.WriteLine("Aferim");
                    }

                }
            }
            else
            {
                Console.WriteLine("Cahil Adam. 12 Ay var...");
                Console.ReadKey();
            }


        }
    }
}
