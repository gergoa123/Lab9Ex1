using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex1
{
    class Autovehicule
    {
        private string producator;
        private string model;
        private Motoarele motor;

        public Autovehicule(string producator, string model, string motor)
        {
            this.model = model;
            this.producator = producator;
            this.motor = new Motoarele(motor);
        }

        public virtual void Porneste()
        {
            motor.Pornire();
        }

        public virtual void Descriere()
        {
            Console.WriteLine(producator + " " + model + " " + motor);
        }

        public override string ToString()
        {
            return producator + " " + model + " " + motor + "\n";
        }
    }
}
