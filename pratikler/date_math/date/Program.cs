using System;

namespace date
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bulunduğumuz tarih ile ilgili işlemler
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            // Haftanın gününü string olarak getirecek
            Console.WriteLine(DateTime.Now.DayOfWeek);

            // Yılın kaçıncı günündeyim
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());  // -> Sunday, October 3, 2021
            Console.WriteLine(DateTime.Now.ToShortDateString()); // -> 10/3/2021

            Console.WriteLine(DateTime.Now.ToLongTimeString());  // -> 7:01:43 PM
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // -> 7:01 PM

            // Ekleme
            Console.WriteLine("##### Ekleme ####");
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            // Format
            Console.WriteLine("##### Format ####");
            Console.WriteLine(DateTime.Now.ToString("dd"));     // 24
            Console.WriteLine(DateTime.Now.ToString("ddd"));    // Sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));   // Saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));     // 04
            Console.WriteLine(DateTime.Now.ToString("MMM"));    // Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM"));   // April

            Console.WriteLine(DateTime.Now.ToString("yy"));     // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy"));   // 2021

            Console.WriteLine(DateTime.Now.ToString("dd MMMM yy"));

            // Tarih tanımlama & Karşılaştırma
            Console.WriteLine("Tarih tanımalama & Karsılastırma");

            DateTime date1 = new DateTime(2010, 11, 23);
            DateTime date2 = new DateTime(2015, 3, 21);

            int result = DateTime.Compare(date1, date2);
            string relationship;

            if (result < 0)
                relationship = "daha eski bir tarihdir";
            else if (result == 0)
                relationship = "tarihler eşittir";
            else
                relationship = "daha yeni bir tarihtir";

            Console.WriteLine("{0}, bu {1} tarihten {2}", date1, date2, relationship);


        }
    }
}
