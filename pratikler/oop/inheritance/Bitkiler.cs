using System;

namespace inheritance
{
    public class Bitkiler : Canlilar
    {

        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
            Console.WriteLine("Bitkiler güneşe tepki verir!");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {

        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.UyaranlaraTepki();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitliler tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitliler sporla çoğalır");
        }
    }
}