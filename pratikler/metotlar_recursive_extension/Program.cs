using System;

namespace metotlar_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recursive Metotlar - Öz yinelemeli
            // 3^4 = 3x3x3x3

            int result = 1;
            for (int i = 0; i < 4; i++)
            {
                result *= 3;
            }

            Islemler islemler = new Islemler();

            Console.WriteLine(islemler.Expo(3, 4));


            // Extension Metotlar
            string ifade = "Yasin Beyazlı";
            bool sonuc = ifade.CheckSpaces();
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperCase());

            int[] dizi = { 9, 5, 3, 1, 4, 8 };

            static int factorial(int n)
            {
                if (n == 2) return n;
                if (n == 1) return n;
                return factorial(n - 1) * n;
            }


        }
    }

    public class Islemler
    {
        /* 
            Expo(3,4)     -> girdi
            Expo(3,3) * 3
            EXpo(3,2) * 3 * 3
            Expo(3,1) * 3 * 3 * 3
            3 * 3 * 3 * 3 -> çıktı
        */
        public int Expo(int sayi, int us)
        {
            if (us < 2)
                return sayi;

            return Expo(sayi, us - 1) * sayi;
        }

    }

    // Nesnesi olması erişmemiz gerekiyor.
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
    }
}
