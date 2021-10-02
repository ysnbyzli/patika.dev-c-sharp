using System;
using System.Collections.Generic;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Pozitif bir tam sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int[] arr = new int[10];


            for (int i = 0; i < number; i++)
            {
                Console.Write("Pozitif bir sayı giriniz: ");
                int checkNumber = int.Parse(Console.ReadLine());

                if (checkNumber % 2 == 0)
                    Console.WriteLine("{0} bir çift sayıdır", checkNumber);

            }

            // 2 - Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            Console.Write("Birinci pozitif tam sayıyı giriniz: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("İkinci pozitif tam sayıyı giriniz: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Bir pozitif tam sayıyı giriniz: ");
                int checkNumber = int.Parse(Console.ReadLine());

                if (checkNumber == m || checkNumber % m == 0)
                    Console.WriteLine(checkNumber);
            }

            // 3- Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            Console.Write("Bir pozitif tam sayı giriniz: ");
            int b = int.Parse(Console.ReadLine());

            List<string> kelimeler = new List<string>();

            for (int i = 0; i < b; i++)
            {
                Console.Write("Bir kelime giriniz: ");
                string kelime = Console.ReadLine();
                kelimeler.Add(kelime);
            }

            foreach (string kelime in kelimeler)
            {
                Console.Write(kelime + " ");
            }

            // 4- Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.Write("Bir cümle giriniz giriniz: ");
            string cumle = Console.ReadLine();

            string[] kelimeArr = cumle.Split(" ");
            string newCumle = string.Join("", kelimeArr);
            char[] harfArr = new char[newCumle.Length];
            for (int i = 0; i < newCumle.Length; i++)
            {
                harfArr[i] = newCumle[i];
            }
            Console.WriteLine(newCumle);
            Console.WriteLine("Kelime sayısı: " + kelimeArr.Length);
            Console.WriteLine("Harf sayısı: " + harfArr.Length);

        }
    }
}
