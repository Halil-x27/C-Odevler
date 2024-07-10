using System;
using System.Collections;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        List<char> sesliHarfler = new List<char>();
        char[] tumSesliHarfler = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };

        foreach (char harf in cumle)
        {
            if (Array.Exists(tumSesliHarfler, element => element == harf))
            {
                sesliHarfler.Add(harf);
            }
        }

        sesliHarfler.Sort();

        Console.WriteLine("\nCümledeki sesli harfler (sıralı):");
        foreach (char harf in sesliHarfler)
        {
            Console.Write(harf + " ");
        }
        }
    }
}
