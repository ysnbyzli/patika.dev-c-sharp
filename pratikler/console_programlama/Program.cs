using System;

namespace console_programlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İsminizi giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyisminizi giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);

        }
    }
}
