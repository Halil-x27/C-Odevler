using System;
using System.Collections;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] sayilar = new int[20];

        for (int i = 0; i < 20; i++)
        {
            while (true)
            {
                Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int sayi))
                {
                    sayilar[i] = sayi;
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                }
            }
        }

        Array.Sort(sayilar);

        int[] enKucuk3 = sayilar.Take(3).ToArray();
        int[] enBuyuk3 = sayilar.Skip(17).Take(3).ToArray();

        double enKucuk3Ort = Ortalama(enKucuk3);
        double enBuyuk3Ort = Ortalama(enBuyuk3);

        Console.WriteLine("\nEn Küçük 3 Sayı:");
        foreach (int sayi in enKucuk3)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("\nEn Büyük 3 Sayı:");
        foreach (int sayi in enBuyuk3)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine($"\nEn Küçük 3 Sayının Ortalaması: {enKucuk3Ort}");
        Console.WriteLine($"En Büyük 3 Sayının Ortalaması: {enBuyuk3Ort}");
        Console.WriteLine($"Ortalama Toplamları: {enKucuk3Ort + enBuyuk3Ort}");
    }

    static double Ortalama(int[] dizi)
    {
        return dizi.Average();
        }
    }
}