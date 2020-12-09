using System;

namespace Sealed02
{
    class Program
    {
        static void Main(string[] args)
        {
            Irregular tri = new Irregular(42.73, 35.05);
            tri.Descricao("Irregular");

            Console.ReadKey();
        }
    }

    public abstract class Triangulo
    {
        private double _base;
        private double _altura;

        public Triangulo(double comprimento = 0.00D, double altura = 0.00D)
        {
            this._base = comprimento;
            this._altura = altura;
        }

        public virtual double Area()
        {
            return this._base * this._altura / 2;
        }

        public void Descricao(string tipo = "")
        {
            Console.WriteLine("Triangulo - {0}", tipo);
            Console.WriteLine("Base  : {0}", this._base);
            Console.WriteLine("Altura: {0}", this._altura);
            Console.WriteLine("Area  : {0}", this.Area());
        }
    }

    public sealed class Irregular : Triangulo
    {
        public Irregular(double Base, double Altura)
            : base(Base, Altura)
        {
        }
    }
}
