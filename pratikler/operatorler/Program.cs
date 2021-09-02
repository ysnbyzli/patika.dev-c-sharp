using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // ATAMA VE İSLEMLİ ATAMA
            int x = 3;
            int y = 3;
            
            y += 2; 
            y /= 1;
            x *= 2;

            // MANTIKSAL OPERATORLER -> &&, ||, !
            bool isSuccess = true;
            bool isCompleted = false;

            string result = isSuccess && isCompleted ? "perfect" : "error";
            Console.WriteLine(result);
            result = isSuccess || isCompleted ? "perfect" : "error";
            Console.WriteLine(result);
            result = isSuccess && !isCompleted ? "perfect" : "error";
            Console.WriteLine(result);

            // ILISKISEL OPERATORLER -> <, >, <=, >=, ==, !=
            int a = 3;
            int b = 4;
            bool sonuc = a < b;
            Console.WriteLine(sonuc);
            sonuc = a > b;
            Console.WriteLine(sonuc);
            sonuc = a <= b;
            Console.WriteLine(sonuc);
            sonuc = a >= b;
            Console.WriteLine(sonuc);
            sonuc = a == b;
            Console.WriteLine(sonuc);
            sonuc = a != b;
            Console.WriteLine(sonuc);


        }
    }
}
