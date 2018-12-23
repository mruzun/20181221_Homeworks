using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[100];
            int[] teks = new int[50];
            int[] cifts = new int[50];
            int ciftsayac = 0;
            int teksayac = 0;
            for (int i = 0; i < 100; i++)
            {
                sayilar[i] = i;
                if (i % 2 == 0)
                {
                    cifts[ciftsayac] = i;
                    ciftsayac++;
                }
                else
                {
                    teks[teksayac] = i;
                    teksayac++;
                }
            }
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
                //if (cifts[i] != 0)
                //{
                    Console.Write(cifts[i] + "-");
                //}

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Tek sayılar ({0})",teksayac);
            for (int i = 0; i < teks.Length; i++)
            {
                //if (teks[i] != 0)
                //{
                    Console.Write(teks[i] + "-");
                //}
            }
        }
    }
}
