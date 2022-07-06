using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex1
{
    class Autoturisme : Autovehicule
    {
        private int locuri;

        public Autoturisme(int locuri, string producator, string model, string motor) : base(producator, model, motor)
        {
            if (motor == "electric" || motor == "hibrid")
            {
                if (locuri <= 0)
                    this.locuri = 1;
                else
                    this.locuri = locuri;
            }
            else
            {
                Console.WriteLine("Wrong motor type");
                return;
            }
        }

        public override void Porneste()
        {
            base.Porneste();
            Console.WriteLine("Doors closed");
        }

        public override void Descriere()
        {
            base.Descriere();
            Console.WriteLine("Nr. locuri: " + locuri);
        }

        public override string ToString()
        {
            return base.ToString() + "Nr. locuri: " + locuri + "\n";
        }
    }
}
