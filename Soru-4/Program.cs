using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[100];
            double[] teks = new double[50];
            double[] cifts = new double[50];
            double[] diziort = new double[50];
            int ciftsayac = 0;
            int teksayac = 0;
            for (int i = 0; i < 100; i++)
            {
                sayilar[i] = i;
                if (i==0)
                {
                    cifts[ciftsayac] = i;
                    ciftsayac++;
                }
                else if (i % 2 == 0)
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

            for (int i = 0; i < diziort.Length; i++)
            {

                if (teks[i] != 0 && cifts[i] != 0)
                {
                    diziort[i] = (teks[i] + cifts[i]) / 2;
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
                //if (i==0)
                //{
                //    Console.Write(cifts[i] + "-");

                //}
                //else if (cifts[i] != 0)
                //{
                    Console.Write(cifts[i] + "-");
                //}

            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Tek sayılar({0})",teksayac);
            for (int i = 0; i < teks.Length; i++)
            {
                //if (teks[i] != 0)
                //{
                   Console.Write(teks[i] + "-");
                //}
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n******************************************");
            Console.WriteLine("Ortalama sayılar");
            for (int i = 0; i < diziort.Length; i++)
            {
                //if (diziort[i] != 0)
                //{
                    Console.Write(diziort[i] + " - ");
                //}
            }
        }
    }
}
