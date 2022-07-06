using System;

namespace Lab9Ex1
{
    class Program
    {
        static void Main()
        {
            Autovehicule autovehicul0 = new Autovehicule("Mercedes", "A6", "hibrid");
            autovehicul0.Porneste();
            autovehicul0.Descriere();
            
            Console.WriteLine("\n");

            Autovehicule autovehicul1 = new Autoturisme(5, "BMW", "X7", "electric");
            autovehicul1.Porneste();
            autovehicul1.Descriere();

            Console.WriteLine("\n");

            Autoturisme autoturism0 = new Autoturisme(2, "Lamborghini", "Huracan", "diesel");
            autoturism0.Porneste();
            autoturism0.Descriere();

            Console.WriteLine("\n");

            Autoutilitare autoutilitar0 = new Autoutilitare("cisterna", "MAN", "Mare", "diesel");
            autoutilitar0.Porneste();
            autoutilitar0.IncarcaMarfa(500f);
            autoutilitar0.Descriere();

            Console.WriteLine("\n");

            Autoutilitare autoutilitar1 = new Autoutilitare("camion", "MAN", "Mare", "diesel");
            autoutilitar1.Porneste();
            autoutilitar1.IncarcaMarfa(40f);
            autoutilitar1.Descriere();

            Console.WriteLine("\n");

            Autoutilitare autoutilitar2 = new Autoutilitare("camion", "MAN", "Mare", "diesel");
            autoutilitar2.Porneste();
            autoutilitar2.IncarcaMarfa(41f);
            autoutilitar2.Descriere();

            Console.WriteLine("\n");

            Autoutilitare autoutilitar3 = new Autoutilitare("camion", "MAN", "Mare", "hibrid");
            autoutilitar3.Porneste();
            autoutilitar3.IncarcaMarfa(40f);
            autoutilitar3.Descriere();

        }
    }
}
