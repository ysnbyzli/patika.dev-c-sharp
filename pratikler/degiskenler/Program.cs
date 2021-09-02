using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            String degisken = "";
            
            // NUMBER
            byte b = 1;             // 0 - 255          -> 1 byte
            sbyte c = 1;            // -127 - 128       -> 1 byte
            short s = 2;            // -32768 - 32768   -> 2 byte
            ushort us = 2;          // 0 - 65365        -> 2 byte
            Int16 i16 = 2;          //                  -> 2 byte
            int i = 4;              //                  -> 4 byte
            Int32 i32 = 4;          //                  -> 4 byte
            Int64 i64 = 8;          //                  -> 8 byte
            uint ui = 4;            //                  -> 4 byte
            long l = 4;             //                  -> 8 byte
            ulong ul = 4;           //                  -> 8 byte;
            float f = 4;            //                  -> 4 byte;
            double d = 8;           //                  -> 8 byte;
            decimal de = 16;        //                  -> 16 byte;

            // CHARACTER
            char ch = '2';          //                  -> 2 byte
            string str = "Yasin";   //                  -> sınırsız 
            bool b1 = true;         
            bool b2 = false;

            // DATE
            DateTime dt = DateTime.Now; // 9/2/2021 10:57:32 AM
            DateTime date1 = new DateTime(2008, 5, 1, 8, 30, 52);  // belirli bir tarih oluşturur.
            DateTime date2= DateTime.Today; // 9/2/2021 12:00:00 AM

            string dateString = "5/1/2008 8:30:52 AM";
            DateTime date3 = DateTime.Parse(dateString);

            DateTime date4 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date4.ToString("F", new System.Globalization.CultureInfo("tr-TR")));

            var date5 = new DateTime(2008, 3, 1, 7, 0, 0);
            Console.WriteLine(date1.ToString("yyyy-MM-dd-T-HH:mm:ssZ"));

            


            // OBJECT
            object o1 = "x";
            object o2 = "y";
            object o3 = 4;
            object o4 = 4.3;

            // STRING
            string str1 = string.Empty; // alternatif -> "", null
            str1 = "Yasin Beyazlı";

            string ad = "Yasin";
            string soyad = "Beyazlı";
            string tamisim = ad + soyad;

            string deger = 10 > 2 ? "dogru" : "yanlis";

            // INTEGER
            int int1 = 5;
            int int2 = 3;
            int int3 = int1 * int2;

            // DEGISKEN DONUSUMLERI
            string str2 = "20";
            int int4 = 20;
            string yeniDeger = str2 + int4.ToString();

            int int5 = int4 + Convert.ToInt32(str2);

            int int6 = int4 + int.Parse(str2);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy"); // 09.02.2021
            string hour = DateTime.Now.ToString("HH:mm"); // 11:13
        }
    }
}
