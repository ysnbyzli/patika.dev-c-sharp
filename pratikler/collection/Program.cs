using System;
using System.Collections.Generic;
namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Bordo");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");


            // Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            // Foreach
            sayiListesi.ForEach(number => Console.WriteLine(number));
            renkListesi.ForEach(color => Console.WriteLine(color));

            // Remove
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            // Remove At
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            // Contains
            sayiListesi.Contains(10);
            // Find
            sayiListesi.Find(number => number == 34);

            // BinarySearch -> Index'ini verir
            renkListesi.BinarySearch("Sarı");

            // Array to list
            string[] hayvanlarArr = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarList = new List<string>(hayvanlarArr);

            // Clear
            hayvanlarList.Clear();

            // ####### //

            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar("Yasin", "Beyazli", 22);
            Kullanicilar kullanici2 = new Kullanicilar("Ayşe", "Beyazli", 22);
            Kullanicilar kullanici3 = new Kullanicilar("Asel", "Beyazli", 12);

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);
            kullanicilarListesi.Add(kullanici3);

            kullanicilarListesi.ForEach(kullanici => Console.WriteLine(kullanici.Isim));



        }
    }

    public class Kullanicilar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public Kullanicilar(string isim, string soyisim, int yas)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.yas = yas;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
