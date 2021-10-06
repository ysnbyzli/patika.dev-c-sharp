using System;
using System.Collections.Generic;

namespace telefonRehberi
{
    class Program
    {
        public static int start()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n(6) Çıkış Yapmak");
            return int.Parse(Console.ReadLine());
        }
        public static void add(List<Person> persons)
        {
            Console.Write("Lütfen isim giriniz             :");
            string name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            string lastName = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            string phone = Console.ReadLine();

            Person person = new Person(name, lastName, phone);

            persons.Add(person);

            Console.WriteLine(person.Name + " rehberinize eklendi");
        }

        public static void show(List<Person> persons)
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            persons.ForEach(person =>
            {
                Console.WriteLine("İsim                 :{0}", person.Name);
                Console.WriteLine("Soyisim              :{0}", person.LastName);
                Console.WriteLine("Telefon Numarası     :{0}", person.PhoneNumber);
                Console.WriteLine("---------------------");
            });
        }

        public static Person getPersonByNameOrLastName(List<Person> persons, String value)
        {
            return persons.Find(p => p.Name.Equals(value) || p.LastName.Equals(value));
        }

        public static List<Person> getPersonsByNameOrLastName(List<Person> persons, String value)
        {
            return persons.FindAll(p => p.Name.Equals(value) || p.LastName.Equals(value));
        }

        public static Person getPersonByPhoneNumber(List<Person> persons, String phone)
        {
            return persons.Find(p => p.PhoneNumber.Equals(phone));
        }

        public static void delete(ref List<Person> persons)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string value = Console.ReadLine();

            Person person = null;
            person = getPersonByNameOrLastName(persons, value);

            if (person == null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");

                int selected = int.Parse(Console.ReadLine());

                if (selected == 1)
                {
                    return;
                }
                else
                {

                    Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    value = Console.ReadLine();
                    person = getPersonByNameOrLastName(persons, value);

                    if (person != null)
                    {
                        Console.Write(person.Name + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz?(y/n)");
                        char confirmation = Convert.ToChar(Console.ReadLine());

                        if (confirmation.Equals('y'))
                        {
                            List<Person> filtered = new List<Person>();

                            foreach (Person p in persons)
                            {
                                if (p.Name.Equals(value) || p.LastName.Equals(value))
                                {

                                }
                                else
                                {
                                    filtered.Add(p);
                                }

                            }
                            persons = filtered;
                            Console.WriteLine("{0} adlı kişi rehberinizden silindi!", person.Name);
                        }
                    }

                }
            }
            else
            {
                Console.Write(person.Name + " isimli kişi rehberden silinmek üzere, onaylıyor musunuz?(y/n)");
                char confirmation = Convert.ToChar(Console.ReadLine());

                if (confirmation.Equals('y'))
                {
                    List<Person> filtered = new List<Person>();

                    foreach (Person p in persons)
                    {
                        if (p.Name.Equals(value) || p.LastName.Equals(value))
                        {

                        }
                        else
                        {
                            filtered.Add(p);
                        }

                    }
                    persons = filtered;
                    Console.WriteLine("{0} adlı kişi rehberinizden silindi!", person.Name);
                }
            }

        }

        public static void find(List<Person> persons)
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");

            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int selected = int.Parse(Console.ReadLine());

            if (selected == 1)
            {
                Console.WriteLine("İsim yada soyisim giriniz");
                string value = Console.ReadLine();
                List<Person> personList = getPersonsByNameOrLastName(persons, value);

                foreach (Person p in personList)
                {
                    Console.WriteLine("İsim:                {0}", p.Name);
                    Console.WriteLine("Soyisim:             {0}", p.LastName);
                    Console.WriteLine("Telefon Numarası:    {0}", p.PhoneNumber);
                    Console.WriteLine("------------------------");
                }
            }
            else
            {
                Console.Write("İsim yada soyisim giriniz: ");
                string value = Console.ReadLine();
                Person person = getPersonByPhoneNumber(persons, value);
                Console.WriteLine("İsim:                {0}", person.Name);
                Console.WriteLine("Soyisim:             {0}", person.LastName);
                Console.WriteLine("Telefon Numarası:    {0}", person.PhoneNumber);
                Console.WriteLine("------------------------");
            }
        }

        public static void update(ref List<Person> persons)
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            string value = Console.ReadLine();

            Person person = getPersonByNameOrLastName(persons, value);

            List<Person> newList = new List<Person>();

            if (person != null)
            {
                Console.Write("Yeni telefon numarasını giriniz: ");
                string newPhoneNumber = Console.ReadLine();
                foreach (Person p in persons)
                {
                    if (p.Name.Equals(value) || p.LastName.Equals(value))
                    {
                        p.PhoneNumber = newPhoneNumber;
                    }

                    newList.Add(p);
                }
                Console.WriteLine(person.Name + " adlı kişinin telefonu güncellendi!");
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine("* Yeniden denemek için              : (2)");
                int selected = int.Parse(Console.ReadLine());
                if (selected == 1)
                {
                    return;
                }
                else
                {
                    Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                    value = Console.ReadLine();
                    person = getPersonByNameOrLastName(persons, value);
                    if (person != null)
                    {
                        Console.Write("Yeni telefon numarasını giriniz: ");
                        string newPhoneNumber = Console.ReadLine();
                        foreach (Person p in persons)
                        {
                            if (p.Name.Equals(value) || p.LastName.Equals(value))
                            {
                                p.PhoneNumber = newPhoneNumber;
                            }

                            newList.Add(p);
                        }
                        Console.WriteLine(person.Name + " adlı kişinin telefonu güncellendi!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            // Default item
            Person yasin = new Person("Yasin", "Beyazlı", "123456789");
            Person ali = new Person("Ali", "Veli", "987654321");
            Person mehmet = new Person("Mehmet", "Sarı", "654987321");
            Person muhammet = new Person("Muhammet", "Mubarek", "321654987");
            Person gokhan = new Person("Gokhan", "Durmus", "741852368");

            persons.Add(yasin);
            persons.Add(ali);
            persons.Add(mehmet);
            persons.Add(muhammet);
            persons.Add(gokhan);

            int selected = start();

            while (true)
            {
                if (selected == 6)
                    break;

                switch (selected)
                {
                    case 1:
                        add(persons);
                        selected = start();
                        break;
                    case 2:
                        delete(ref persons);
                        selected = start();
                        break;
                    case 3:
                        update(ref persons);
                        selected = start();
                        break;
                    case 4:
                        show(persons);
                        selected = start();
                        break;
                    case 5:
                        find(persons);
                        selected = start();
                        break;
                }
            }

        }
    }
}
