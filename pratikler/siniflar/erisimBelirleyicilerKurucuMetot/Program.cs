using System;

namespace erisimBelirleyicilerKurucuMetot
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan = new Calisan("Yasin", "Beyazlı", "107", "Yazılım Geliştirici");
            calisan.CalisanBilgileri();

        }
    }

    class Calisan
    {
        private string ad;
        private string soyad;
        private string no;
        private string departman;

        public Calisan()
        {

        }
        public Calisan(string ad, string soyad, string no, string departman)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.no = no;
            this.departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", this.ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", this.soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", this.no);
            Console.WriteLine("Çalışanın Departmanı: {0}", this.departman);
        }


    }
}
