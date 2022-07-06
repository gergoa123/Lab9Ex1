using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9Ex1
{
    class Motoarele
    {
        private string tip;

        public Motoarele(string tip)
        {
            this.tip = tip;
        }

        public void Pornire()
        {
            switch (tip)
            {
                case "electric":
                    Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzz");
                    break;
                case "diesel":
                    Console.WriteLine("brbrbrbrbrbrbrbrbrbrbrbrbrbrbrbr");
                    break;
                case "hibrid":
                    Console.WriteLine("brbrzzzzbrbrzzzzbrbrzzzzbrbrzzzz");
                    break;

                default:
                    Console.WriteLine("Nu s-a gasit motor cu tipul: " + tip);
                    break;
            }
        }

        public override string ToString()
        {
            return tip;
        }
    }
}
