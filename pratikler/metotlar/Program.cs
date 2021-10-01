using System;

namespace metotlar
{
    class Program
    {

        public static int sum(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {

            Console.WriteLine(sum(5, 20));

            Metotlar metotlar = new Metotlar();
            metotlar.WriteScreen("Hello World!");

            int a = 23;
            int b = 34;

            metotlar.increaseAndCollect(ref a, ref b);

            // out parametreler
            int outNumber;
            string number = "999";

            bool result = int.TryParse(number, out outNumber);

            if (result)
            {
                Console.Write("Başarılı: ");
                Console.WriteLine(outNumber);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            int toplam;

            metotlar.collect(20, 43, out toplam);

            Console.WriteLine("Toplam: " + toplam);

            metotlar.WriteScreen(5);
        }
    }

    class Metotlar
    {

        public void WriteScreen(string value)
        {
            Console.WriteLine(value);
        }

        public void WriteScreen(int value)
        {
            Console.WriteLine(value);
        }
        public int increaseAndCollect(ref int number1, ref int number2)
        {
            number1++;
            number2++;
            return number1 + number2;
        }

        public int collect(int a, int b, out int toplam)
        {
            return toplam = a + b;
        }

    }
}
