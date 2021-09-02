using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz dönüşüm)

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;  // d bunlardan daha az deger tutan olsaydı hata alırdık.

            long h = d;

            float i = h;

            string e = "yasin";
            char f = 'k';

            object g = e + f + d;

            // Explicit Conversion (Bilinçli dönüşüm)

            int x = 4;
            byte y = (byte) x;

            int z = 100;
            byte t = (byte) z;

            float w = 10.3f;
            byte v = (byte) w;

            int xx = 6;
            string yy = xx.ToString();

            string s1 = "10", s2 = "20";
            int sayi1, sayi2, toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;

            parseMethod();


        }

        public static void parseMethod(){
            string s1 = "10";
            string s2 = "10.25";
            int i1;
            double d1;

            i1 = Int32.Parse(s1);
            d1 = double.Parse(s2); 
        }
    }
}
