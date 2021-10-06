using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            
                                        Canlılar
                        Bitkiler                    Hayvanlar
            Tohumlu              Tohumsuz       Surungenler         Kuslar
            
            */

            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.Beslenme();


        }
    }
}
