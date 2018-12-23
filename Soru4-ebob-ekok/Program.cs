using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4_ebob_ekok
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            int[] teks = new int[5];
            int[] cifts = new int[5];

            Random rnd = new Random();
            int rndsayi = new int();

            int ciftsayac = 0;
            int teksayac = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                rndsayi = rnd.Next(2, 100);
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
            int[] tambolunentek = new int[100];
            int[] tambolunencift = new int[100];
            int tbsc = 0;
            int tbst = 0;
            for (int i = 0; i < teks.Length; i++)
            {
                for (int j =1; j < teks[i]; j++)
                {
                    if (teks[i]%j==0)
                    {
                        tambolunentek[tbst] = j;
                        tbst++;
                    }
                }
            }
            Array.Sort(tambolunentek);
            Array.Reverse(tambolunentek);
            int farklit = 0;
            for (int i = 0; i < teks.Length; i++)
            {
                if (teks[i]!=0)
                {
                    farklit++;
                }
            }
            int o = 1;
            int tebob=0;
            for (int i = 0; i < tambolunentek.Length; i++)
            {
                if (i+1<tambolunentek.Length)
                {
                    if (tambolunentek[i]==tambolunentek[i+1])
                    {
                        o++;
                        if (o==farklit)
                        {
                            tebob = tambolunentek[i];
                            break;
                        }
                    }
                    else
                    {
                        o = 1;
                    }

                }
            }

            for (int i = 0; i < cifts.Length; i++)
            {
                for (int j = 1; j < cifts[i]; j++)
                {
                    if (cifts[i] % j == 0)
                    {
                        tambolunencift[tbsc] = j;
                        tbsc++;
                    }
                }
            }
            Console.WriteLine("Tek sayılar ebob : "+tebob);
            Console.WriteLine("teksayılar");
            foreach (var item in teks)
            {
                if (item != 0)
                {
                    Console.WriteLine(item + "-");
                }
            }
            Console.WriteLine("tambolunentek");
            foreach (int item in tambolunentek)
            {
                if (item!=0)
                {
                Console.WriteLine(item + "-");
                }
            }
            Console.WriteLine("ciftsayılar");
            foreach (var item in cifts)
            {
                if (item != 0)
                {
                    Console.WriteLine(item + "-");
                }
            }
            Console.WriteLine("tambolunencift");
            foreach (int item in tambolunencift)
            {
                if (item != 0)
                {
                    Console.WriteLine(item + "-");
                }
            }
        }
    }
}
