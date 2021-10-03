using System;

namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mutlak alma
            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine(Math.Ceiling(10.1));  // Yukarı yuvarlar
            Console.WriteLine(Math.Floor(10.8));    // Aşağı yuvarlar
            Console.WriteLine(Math.Round(10.1));    // En yakın sayıya yuvarlar

            Console.WriteLine(Math.Max(10, 23));
            Console.WriteLine(Math.Min(23, 12));

            Console.WriteLine(Math.Pow(3, 4));
        }
    }
}
