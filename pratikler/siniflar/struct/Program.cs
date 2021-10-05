using System;

namespace structDers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisaKenar = 7;
            dikdortgen.uzunKenar = 12;

            Console.WriteLine("Alan: " + dikdortgen.AlanHesapla());

            Dikdortgen_Strurct dikdortgen_Strurct = new Dikdortgen_Strurct(7, 12);

            Console.WriteLine("Alan: " + dikdortgen_Strurct.AlanHesapla());
        }
    }

    class Dikdortgen
    {

        public int kisaKenar;
        public int uzunKenar;
        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

    }

    struct Dikdortgen_Strurct
    {
        public int kisaKenar;
        public int uzunKenar;

        public Dikdortgen_Strurct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }
    }

}
