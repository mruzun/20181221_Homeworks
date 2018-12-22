using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_5_Obeb_Okek
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sayilar = new double[5];
            double[] teks = new double[5];
            double[] cifts = new double[5];
            double[] tambolunencift = new double[50];
            double tut1 = 1;
            double tut2 = 1;
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


            Array.Sort(cifts);
            int s = 0;
            for (int i = 0; i < cifts.Length; i++)
            {
                for (int j = 1; j <= cifts[i]; j++)
                {
                    if (j == 1)
                    {
                        tambolunencift[s] = j;
                        s++;
                    }
                    else if (cifts[i] % j == 0)
                    {
                        tambolunencift[s] = j;
                        s++;
                    }
                }
            }
            for (int c = 0; c < tambolunencift.Length; c++)
            {
                if (c==0)
                {
                    tut1 = tambolunencift[c];
                }
                else if (tut1<tambolunencift[c])
                {
                    tut2 = tut1;
                }
            }
            double t = 0;
            int say = 0;
            for (int i = 0; i < tambolunencift.Length; i++)
            {
                if (tambolunencift[i]>1)
                {
                    say++;
                    t = tambolunencift[i];
                    if (say==cifts.Length)
                    {
                        break;
                    }
                }
            }
            
            foreach (var item in tambolunencift)
            {
                Console.Write(item+" - ");
            }
           
            #region yazdırma
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
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("\n******************************************");
            //Console.WriteLine("Tek sayılar");
            //for (int i = 0; i < teks.Length; i++)
            //{
            //    if (teks[i] != 0)
            //    {
            //        Console.Write(teks[i] + "-");
            //    }
            //}
           
            #endregion
            Console.ReadKey();
        }
    }
}
