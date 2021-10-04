using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> map = new Dictionary<int, string>();

            map.Add(1, "Yasin");
            map.Add(2, "Ayşe");
            map.Add(3, "Asel");
            map.Add(4, "Hasan");
            map.Add(5, "Bilgen");

            Console.WriteLine(map[2]);

            foreach (var item in map)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(map.Count);

            Console.WriteLine(map.ContainsKey(3));
            Console.WriteLine(map.ContainsValue("Bilgen"));


        }
    }
}
