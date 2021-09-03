using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {   
            /*
            try
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            } 
            */

            try
            {
                int a = int.Parse("-2000000000000"); 
            }
            catch (OverflowException ex) {
                Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz!");
                Console.WriteLine(ex.Message.ToString());
            }

            

        }
    }
}
