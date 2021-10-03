using System;

namespace string_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoş geldiniz!";
            string degisken2 = "Dersimiz Csharp";

            // Length
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba"));

            // Compare, CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1, -1
            Console.WriteLine(String.Compare(degisken, degisken2, true)); // büyük küçük harf duyarlılıgı

            // Contains
            Console.WriteLine(degisken.Contains(degisken2));

            // EndsWitht, StartsWith
            Console.WriteLine(degisken.StartsWith("Ders"));
            Console.WriteLine(degisken2.EndsWith("arp"));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("ers")); // bulamazsa -1

            // Insert
            Console.WriteLine(degisken.Insert(0, "Merhaba")); // belirtilen index'ten baslayarak parametrede verilen veriyi ekler

            // PadLeft, ParRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));

            // Remove
            Console.WriteLine(degisken.Remove(10)); // 10. indexten baslayarak kalanları siler.
            Console.WriteLine(degisken.Remove(5, 3)); // 5. indexten baslayarak 3 karakter sil.
            Console.WriteLine(degisken.Remove(0, 1)); // en bastaki harfi siler.

            // Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));

            // Split
            Console.WriteLine(degisken.Split(" ")[1]);

            // Substring
            Console.WriteLine(degisken.Substring(4));  // 4. indexten sonra hepsini alır
            Console.WriteLine(degisken.Substring(4, 5)); // 4. indexten sonra 5 karakter getirir.
        }
    }
}
