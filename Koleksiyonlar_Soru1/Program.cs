using System;
using System.Collections;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
           ArrayList asalListesi = new ArrayList();
        ArrayList asalOlmayanListesi = new ArrayList();

        int sayac = 0;
        while (sayac < 20)
        {
            Console.Write($"Lütfen pozitif bir sayı giriniz ({sayac + 1}/20): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int sayi) && sayi > 0)
            {
                if (AsalMi(sayi))
                {
                    asalListesi.Add(sayi);
                }
                else
                {
                    asalOlmayanListesi.Add(sayi);
                }
                sayac++;
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı giriniz.");
            }
        }

        asalListesi.Sort();
        asalListesi.Reverse();
        asalOlmayanListesi.Sort();
        asalOlmayanListesi.Reverse();

        Console.WriteLine("\nAsal Sayılar:");
        foreach (int asal in asalListesi)
        {
            Console.WriteLine(asal);
        }

        Console.WriteLine("\nAsal Olmayan Sayılar:");
        foreach (int asalOlmayan in asalOlmayanListesi)
        {
            Console.WriteLine(asalOlmayan);
        }

        Console.WriteLine($"\nAsal Sayılar Listesi Eleman Sayısı: {asalListesi.Count}");
        Console.WriteLine($"Asal Sayılar Listesi Ortalaması: {Ortalama(asalListesi)}");

        Console.WriteLine($"\nAsal Olmayan Sayılar Listesi Eleman Sayısı: {asalOlmayanListesi.Count}");
        Console.WriteLine($"Asal Olmayan Sayılar Listesi Ortalaması: {Ortalama(asalOlmayanListesi)}");
    }

    static bool AsalMi(int sayi)
    {
        if (sayi <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0) return false;
        }
        return true;
    }

    static double Ortalama(ArrayList list)
    {
        if (list.Count == 0) return 0;
        int toplam = 0;
        foreach (int sayi in list)
        {
            toplam += sayi;
        }
        return (double)toplam / list.Count;
    }

        
    }
}
