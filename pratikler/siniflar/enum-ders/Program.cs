using System;

namespace enum_ders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazartesi);
            Console.WriteLine((int)Gunler.Cumartesi);

            Console.Write("Hava Sıcaklığını giriniz: ");
            int sicaklik = Convert.ToInt32(Console.ReadLine());

            if (sicaklik <= (int)HavaSicakligi.Soguk)
            {
                Console.WriteLine("Hava çok soguk!");
            }
            else if (sicaklik <= (int)HavaSicakligi.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz ısınmasını bekleyebilirsiniz!");
            }
            else if (sicaklik <= (int)HavaSicakligi.Sicak)
            {
                Console.WriteLine("Dışarıya çıkmak için sıcak bir gün!");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaSicakligi
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
