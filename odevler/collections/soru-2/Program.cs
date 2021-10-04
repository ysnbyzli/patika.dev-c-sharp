using System;

namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((i + 1) + ". sayıyı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                arr[i] = sayi;

            }

            Array.Sort(arr);

            int[] buyukler = { arr[arr.Length - 1], arr[arr.Length - 2], arr[arr.Length - 3] };
            int[] kucukler = { arr[0], arr[1], arr[2] };

            int kucuklerToplam = 0;
            int buyuklerToplam = 0;

            foreach (int item in buyukler)
            {
                buyuklerToplam += item;
            }

            foreach (int item in kucukler)
            {
                kucuklerToplam += item;
            }

            Console.WriteLine("Buyuk sayıların toplamı: " + buyuklerToplam);
            Console.WriteLine("Buyuk sayıların ortalaması: " + buyuklerToplam / buyukler.Length);

            Console.WriteLine("Kucuk sayıların toplamı: " + kucuklerToplam);
            Console.WriteLine("Kucuk sayıların ortamalası: " + kucuklerToplam / kucukler.Length);

        }

    }
}

