using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[20];
            int[] teks = new int[20];
            int[] cifts = new int[20];
            Random rnd = new Random();
            int rndsayi = new int();
            int ciftsayac = 0;
            int teksayac = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                rndsayi = rnd.Next(1, 100);
                sayilar[i] = rndsayi;
                if (sayilar[i] % 2 == 0)
                {
                    cifts[ciftsayac] = rndsayi;
                    ciftsayac++;
                }
                else
                {
                    teks[teksayac] = rndsayi;
                    teksayac++;
                }
            }
            Console.WriteLine("\n******************************************");

            Console.WriteLine("Tüm Sayılar");
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write(sayilar[i] + "-");

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Çift sayılar ({0})",ciftsayac);
            for (int i = 0; i < cifts.Length; i++)
            {
                if (cifts[i] != 0)
                {
                    Console.Write(cifts[i] + "-");
                }

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Ortalama sayılar ({0})",teksayac);
            for (int i = 0; i < teks.Length; i++)
            {
                if (teks[i] != 0)
                {
                    Console.Write(teks[i] + "-");
                }
            }
            Console.ReadKey();
        }
    }
}
