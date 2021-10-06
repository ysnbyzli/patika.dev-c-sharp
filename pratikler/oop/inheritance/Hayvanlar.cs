using System;

namespace inheritance
{
    public class Hayvanlar : Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }

        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir!");
        }

    }

    public class Surungenler : Hayvanlar
    {
        public void SurunerekHareketEtme()
        {
            Console.WriteLine("Surungenler sürünerek hareket eder.");
        }

    }

    public class Kuslar : Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar");
        }
    }
}