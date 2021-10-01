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

        }
    }

    class Metotlar
    {

        public void WriteScreen(string value)
        {
            Console.WriteLine(value);
        }

        public int increaseAndCollect(ref int number1, ref int number2)
        {
            number1++;
            number2++;
            return number1 + number2;
        }

    }
}
