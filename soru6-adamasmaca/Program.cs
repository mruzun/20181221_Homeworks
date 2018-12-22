using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soru6_adamasmaca
{
    class Program
    {
        static void Main(string[] args)
        {

            Baslangic:
                string[] kelimeler = { "VOLKAN", "EMRE", "YILDIRIM", "HALIS", "FATIH", "AHMET", "METIN", "SAMET", "ASLI", "OKAN", "UĞUR", "EDA", "FATMA", "KURŞAT", "MEHMET" };
                Random r = new Random();
                int secilenKelimeIndex = r.Next(0, kelimeler.Length);
                string secilenKelime = kelimeler[secilenKelimeIndex];
                int can = secilenKelime.Length + 3;
                char[] guncelKelime = new char[secilenKelime.Length];
                for (int k = 0; k < secilenKelime.Length; k++)
                {
                    guncelKelime[k] = '_';
                }
                Console.WriteLine("KELIME HARF SAYISI = {0}", secilenKelime.Length);
                while (can > 0 && guncelKelime.Contains('_'))
                {
                
                    Console.WriteLine("**************");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("GUNCEL KELIME = ");
                    Console.WriteLine(guncelKelime);
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write("HARF TAHMİN ET = ");

                    char tahmin = char.Parse(Console.ReadLine().ToUpper());
                    Console.ResetColor();
                    int harfKontrol = 0;
                    for (int t = 0; t < secilenKelime.Length; t++)
                    {
                        if (tahmin == secilenKelime[t])
                        {
                            guncelKelime[t] = tahmin;
                        }
                        else
                        {
                            harfKontrol++;
                        }
                    }
                    if (harfKontrol == secilenKelime.Length)
                    {
                        can--;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("KALAN CAN = " + can);

                    Console.ResetColor();
                }
                if (can == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("KAYBETTİN LAN !");
                TryAgain:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("TEKRAR OYNAMAK İSTER MİSİN YAKIŞIKLI ? (E / H) ");
                    Console.ResetColor();
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.E)
                    {
                        Console.Clear();
                        goto Baslangic;
                    }
                    else if (cki.Key == ConsoleKey.H)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("OYUN BİTTİ ! GÜLE GÜLE ");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SEÇENEKLERİ GÖRMÜYOR MUSUN ! E VEYA H YAZ");
                        Console.ResetColor();
                        goto TryAgain;
                    }
                }

                if (!guncelKelime.Contains('_'))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HELAL LAN SANA");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("TEKRAR OYNAMAK İSTER MİSİN YAKIŞIKLI ? (E / H) ");
                    Console.ResetColor();
                TryAgain:

                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.E)
                    {
                        Console.Clear();
                        goto Baslangic;
                    }
                    else if (cki.Key == ConsoleKey.H)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("OYUN BİTTİ ! GÜLE GÜLE ");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("SEÇENEKLERİ GÖRMÜYOR MUSUN ! E VEYA H YAZ");
                        Console.ResetColor();
                        goto TryAgain;
                    }

                }
                
        }
    }
}
