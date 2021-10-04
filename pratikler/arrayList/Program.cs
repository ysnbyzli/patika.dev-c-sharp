using System;
using System.Collections;
using System.Collections.Generic;
namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Yasin");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // AddRange
            Console.WriteLine("#### Birden fazla eleman ekleme ####");
            string[] renkler = { "Bordo", "Mavi", "Turuncu", "Yeşil", "Sarı" };
            List<int> sayilar = new List<int>() { 1, 5, 2, 43, 65, 76 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Sort
            Console.WriteLine("#### Sıralama ####");
        }
    }
}
