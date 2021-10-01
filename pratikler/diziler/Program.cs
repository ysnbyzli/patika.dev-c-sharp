using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];

            // Deger atama
            renkler[0] = "Kırmızı";
            renkler[1] = "Bordo";
            renkler[2] = "Mavi";
            renkler[3] = "Sarı";
            renkler[4] = "Turuncu";

            // Degere erisme
            Console.WriteLine(renkler[3]);

            // Degerler arasında donme
            foreach (string renk in renkler)
            {
                Console.WriteLine(renk);
            }

            // Donguler dizi kullanımı
            // klavyeden girilen n tane sayının ortalamasını hesaplayan program
            /*
            Console.Write("Lütfen dizinin eleman sayısını giriniz: ");
            int arrLength = int.Parse(Console.ReadLine());

            int[] arr = new int[arrLength];



            for (int i = 0; i < arrLength; i++)
            {
                Console.Write((i + 1) + ". elamanı giriniz: ");
                int value = int.Parse(Console.ReadLine());
                arr[i] = value;
            }

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            */

            /* 
                ^ Metotlar
            */

            // ^ Sort
            Console.WriteLine("#### Sort Kullanımı ####");
            int[] sayiDizisi = { 23, 2, 43, 12, 43, 3, 54, 67 };

            Console.WriteLine("Sırasız Liste");
            foreach (int sayi in sayiDizisi) Console.Write(sayi + " ");

            Console.WriteLine();
            Console.WriteLine("Sıralı liste");
            Array.Sort(sayiDizisi);
            foreach (int sayi in sayiDizisi) Console.Write(sayi + " ");

            // ^ Clear
            Console.WriteLine();
            Array.Clear(sayiDizisi, 2, 2);
            foreach (int sayi in sayiDizisi) Console.Write(sayi + " ");

            // ^ Reverse
            Console.WriteLine();
            Array.Reverse(sayiDizisi);
            foreach (int sayi in sayiDizisi) Console.Write(sayi + " ");


            // ^ IndexOf
            Console.WriteLine();
            Array.IndexOf(sayiDizisi, 23);
        }
    }
}
