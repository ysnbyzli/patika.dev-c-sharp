using System;
using System.Collections.Generic;

namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            List<char> sesliHarfler = new List<char>();

            foreach (char item in cumle)
            {
                if (item.Equals('a') || item.Equals('e') || item.Equals('ı') || item.Equals('i') ||
                    item.Equals('o') || item.Equals('ö') || item.Equals('u') || item.Equals('ü')
                ) sesliHarfler.Add(item);
            }

            sesliHarfler.Sort();

            foreach (var item in sesliHarfler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
