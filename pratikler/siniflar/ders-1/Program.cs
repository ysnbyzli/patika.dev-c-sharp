using System;

namespace ders_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                class SinifAdi {
                    [Erişim Belirleyici] [Veri tipi] özellikAdi;
                    [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdi([Parametre Listes]i)
                    {
                        Metot komutları
                    }
                }


                # Erişim Belirleyiciler
                * public 
                * private
                * Internal
                * Protected


            */

            Calisan calisan = new Calisan();
            calisan.ad = "Yasin";
            calisan.soyad = "Beyazlı";
            calisan.no = "433";
            calisan.departman = "Yazılım Geliştirici";

            calisan.CalisanBilgileri();

            Calisan calisan1 = new Calisan();
            calisan1.ad = "Ayse";
            calisan.soyad = "Beyazlı";
            calisan.no = "107";
            calisan.departman = "Insan Kaynakları";

            calisan.CalisanBilgileri();

        }
    }


    class Calisan
    {
        public string ad;
        public string soyad;
        public string no;
        public string departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı: {0}", this.ad);
            Console.WriteLine("Çalışanın Soyadı: {0}", this.soyad);
            Console.WriteLine("Çalışanın Numarası: {0}", this.no);
            Console.WriteLine("Çalışanın Departmanı: {0}", this.departman);
        }


    }

}
