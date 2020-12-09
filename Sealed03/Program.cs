using System;

namespace Sealed03
{
    class Program
    {
        static void Main(string[] args)
        {
            FormaRedonda circ = new Circulo();
            circ.Raio = 42.86;

            Console.WriteLine("Circulo Characteristics");
            Console.WriteLine("Raio:   {0}", circ.Raio);
            Console.WriteLine("Diametro: {0}", circ.Diametro);
        }
    }
    public abstract class Forma
    {
        public virtual double Raio { get; set; }
        public abstract double Diametro { get; }
    }

    public class Circulo : Forma
    {
        private double rad;

        public sealed override double Raio // sealed antes de  override
        {
            get
            {
                return this.rad;
            }

            set
            {
                this.rad = value;
            }
        }

        public override sealed double Diametro // override antes de sealed => são equivalentes
        {
            get
            {
                return this.rad * 2;
            }
        }
    }

    public sealed class Esfera : Circulo
    {
        private double rad;

        public override double Raio
        {
            get
            {
                return this.rad;
            }

            set
            {
                this.rad = value;
            }
        }
    }
}
