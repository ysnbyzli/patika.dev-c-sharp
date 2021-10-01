using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                ^ Ekrandan girilen sayıya kadar olan tek sayılarını ekrana yazdır.
                Console.Write("Bir sayı giriniz: ");
                int sayac = int.Parse(Console.ReadLine());

                for (int i = 0; i < sayac; i++)
                {
                    if (i % 2 == 1)
                        Console.WriteLine(i);
                }
            */

            /*
                ^ 1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
             */
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;
            }

            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("Cift sayıların toplamı: " + ciftToplam);

            // break, continue
            Console.WriteLine("#### Break Kullanımı ####");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) break;
                Console.WriteLine(i);
            }
            Console.WriteLine("#### Contiune Kullanımı ####");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4) continue;
                Console.WriteLine(i);
            }

            /* 
                ^ While 
            */
            Console.WriteLine("#### While Kullanımı ####");

            // 1'den başlayarak console'dan girilen sayıya kadar sayı dahil ortalama hesaplayıp consola yazdıran program.
            Console.Write("Bir sayı giriniz: ");
            int sayac = 1;
            int toplam = 0;
            int number = int.Parse(Console.ReadLine());

            while (sayac <= number)
            {
                toplam += sayac;
                sayac++;
            }

            Console.WriteLine("Ortalama: " + toplam / number);

            // 'a' dan 'z'ye kadar tüm harfleri console'a yazdıralım.
            Console.WriteLine("##### 'a' dan 'z'ye kadar tüm harfleri console'a yazdıralım. #####");
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character);
                character++;
            }

            /* 
                ^ Foreach
            */
            Console.WriteLine();
            Console.WriteLine("##### Foreach Kullanımı #####");

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };

            foreach (string araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
