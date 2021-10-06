using System;

namespace telefonRehberi
{
    public class Person
    {
        private string name;
        private string lastName;
        private string phoneNumber;

        public Person()
        {
        }

        public Person(string name, string lastName, string phoneNumber)
        {
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}