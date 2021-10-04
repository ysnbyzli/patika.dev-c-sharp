using System;
using System.Collections;
namespace soru_1
{


    class NegativeNumberNotAllowed : Exception
    {
        public NegativeNumberNotAllowed(string message) : base(message)
        {

        }
    }
    class Program
    {

        public static int CheckForNegative(int number)
        {
            if (number < 0) throw new NegativeNumberNotAllowed("Sayı negatif olamaz!");
            return number;
        }

        static void Main(string[] args)
        {
            int sayac = 1;
            ArrayList asalOlanlar = new ArrayList();
            ArrayList asalOlmayanlar = new ArrayList();

            while (sayac <= 10)
            {
                int count = 0;
                Console.Write("Bir sayı giriniz: ");
                try
                {
                    // CheckForNegative - sayının negatif olup olmadıgını kontrol eder negatif ise hata fırlatır.
                    // Eğer bir hata durumu varsa asağıdaki kod satırları okunmayacaktır. Yani sayacı eksiltmemize gerek yoktur.
                    int sayi = CheckForNegative(int.Parse(Console.ReadLine()));
                    // Dögüdeki o an ki değer sayıyı tam bolerse count'u bir arttırır.
                    for (int i = 1; i <= sayi; i++)
                    {
                        if (sayi % i == 0) count++;
                    }
                    // Bir asal sayı sadece 1'e ve kendine tam bölünebildiği için count'un 2'ye eşit olması gerekir.
                    if (count == 2)
                    {
                        asalOlanlar.Add(sayi);
                    }
                    else
                    {
                        asalOlmayanlar.Add(sayi);
                    }
                    // İslem sonunda sayacımızı bir arttırıyor
                    sayac++;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Veri tipi uygun değil!");
                }
                catch (NegativeNumberNotAllowed ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // Sıralama
            asalOlanlar.Sort();
            asalOlmayanlar.Sort();

            // Toplam değişkenleri
            var asalOlanlarToplam = 0;
            int asalOlmayanlarToplam = 0;

            // Asal olanların yazdırılması - toplanması - adeti - ortalaması
            Console.WriteLine("##### Asal Olanlar #####");
            foreach (var item in asalOlanlar)
            {
                Console.Write(item + " ");
                asalOlanlarToplam += (int)item;
            }

            Console.WriteLine();
            Console.WriteLine("Asal olanların sayısı: " + asalOlanlar.Count);
            Console.WriteLine("Asal sayıların ortalaması: " + asalOlanlarToplam / asalOlanlar.Count);

            // Asal olmayanların yazdırılması - toplanması - adeti - ortalaması
            Console.WriteLine("##### Asal Olmayanlar #####");
            foreach (var item in asalOlmayanlar)
            {
                Console.Write(item + " ");
                asalOlmayanlarToplam += (int)item;
            }

            Console.WriteLine();
            Console.WriteLine("Asal olmayanların sayısı: " + asalOlmayanlar.Count);
            Console.WriteLine("Asal olanların ortalaması: " + asalOlmayanlarToplam / asalOlmayanlar.Count);
        }
    }
}
