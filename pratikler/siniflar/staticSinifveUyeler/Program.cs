using System;

namespace staticSinifveUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Yasin", "Beyazlı", "Yazılım Geliştirici");

            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine(Islemler.Topla(100, 200));
            Console.WriteLine(Islemler.Cikar(200, 100));

            Calisan.Hello();
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        private string isim;
        private string soyIsim;
        private string departman;

        static Calisan()  // çalısan sınıfına eriştiğimizde sadece bir kere çalısır
        {
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyIsim, string departman)
        {
            this.isim = isim;
            this.soyIsim = soyIsim;
            this.departman = departman;
            calisanSayisi++;
        }

        public static int CalisanSayisi { get => calisanSayisi; }

        public static void Hello()
        {
            Console.WriteLine("merhaba");
        }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
