using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[20];
            double[] teks = new double[20];
            double[] cifts = new double[20];
            double[] diziort = new double[20];
            Random rnd = new Random();
            int ciftsayac = 0;
            int teksayac = 0;
            int rndsayi = new int();
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
            for (int i = 0; i < sayilar.Length; i++)
            {
                if (teks[i] != 0 && cifts[i] != 0)
                {
                    diziort[i] = (teks[i] + cifts[i]) / 2;
                }
                else if (teks[i] != 0)
                {
                    diziort[i] = teks[i];
                }
                else if (cifts[i]!=0)
                {
                    diziort[i] = cifts[i];
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
            Console.WriteLine("Çift sayılar");
            for (int i = 0; i < cifts.Length; i++)
            {
                if (cifts[i] != 0)
                {
                    Console.Write(cifts[i] + "-");
                }

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Tek sayılar");
            for (int i = 0; i < teks.Length; i++)
            {
                if (teks[i] != 0)
                {
                    Console.Write(teks[i] + "-");
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Tek sayılar");
            for (int i = 0; i < diziort.Length; i++)
            {
                if (diziort[i]!=0)
                {
                    Console.Write(diziort[i] + "-");
                }
                
            }
            Console.ReadKey();
        }
    }
}
