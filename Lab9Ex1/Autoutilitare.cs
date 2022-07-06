using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex1
{
    class Autoutilitare : Autovehicule
    {
        private string transport;
        private float capacitateMaxima;
        private float capacitateCurenta;

        public Autoutilitare(string transport, string producator, string model, string motor) : base(producator, model, motor)
        {
            if (motor == "diesel")
            {
                this.transport = transport;

                if (transport == "cisterna")
                {
                    this.capacitateMaxima = 10000f;
                }
                else if (transport == "camion")
                {
                    this.capacitateMaxima = 40f;
                }
                else
                {
                    Console.WriteLine("Tip capacitate gresita");
                }

                this.capacitateCurenta = 0f;
            }
            else
            {
                Console.WriteLine("Wrong motor type");
                return;
            }
        }

        public void IncarcaMarfa(float cantitate)
        {
            if (capacitateCurenta + cantitate < capacitateMaxima)
            {
                capacitateCurenta += cantitate;
            }
            else
            {
                Console.WriteLine("Can't fit");
            }
        }

        public override void Descriere()
        {
            base.Descriere();
            Console.WriteLine("Transport: " + transport + "\nCapacitate maxima: " + capacitateMaxima + "\nCapacitate curenta: " + capacitateCurenta);
        }

        public override string ToString()
        {
            return base.ToString() + "Transport: " + transport + "\nCapacitate maxima: " + capacitateMaxima + "\nCapacitate curenta: " + capacitateCurenta + "\n";
        }

        public override void Porneste()
        {
            base.Porneste();
        }
    }
}
