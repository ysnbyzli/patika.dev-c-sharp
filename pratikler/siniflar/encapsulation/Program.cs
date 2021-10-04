using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Name = "Yasin";
            ogrenci.LastName = "Beyazlı";
            ogrenci.No = 107;
            ogrenci.ClassRoom = 3;

            ogrenci.OgrneciBilgileri();

            ogrenci.SinifAtlat();

            ogrenci.OgrneciBilgileri();
        }
    }

    class Ogrenci
    {
        private string name;
        private string lastName;
        private int no;
        private int classRoom;

        public Ogrenci()
        {
        }

        public Ogrenci(string name, string lastName, int no, int classRoom)
        {
            Name = name;
            LastName = lastName;
            No = no;
            ClassRoom = classRoom;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int No { get => no; set => no = value; }
        public int ClassRoom
        {
            get => classRoom;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir!");
                    classRoom = 1;
                }
                else
                    classRoom = value;
            }
        }

        public void OgrneciBilgileri()
        {
            Console.WriteLine("####### Ogrenci Bilgileri #######");
            Console.WriteLine("Öğrenci Adı       : {0}", this.Name);
            Console.WriteLine("Öğrenci Soyadı    : {0}", this.LastName);
            Console.WriteLine("Öğrenci No        : {0}", this.No);
            Console.WriteLine("Öğrenci Sınıfı    : {0}", this.ClassRoom);
        }

        public void SinifAtlat()
        {
            this.ClassRoom += 1;
        }

        public void SinifDusur()
        {
            this.ClassRoom -= 1;
        }
    }

}
