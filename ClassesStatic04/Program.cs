using System;

namespace ClassesStatic04
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            Abaco abaco = new Abaco();
            Console.ReadKey();
        }
    }

    public class Calculadora
    {
        protected string DireitosAutorais = "Lucas S Lima";
        public static int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        protected int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
        public static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public static int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }
    }

    public class Abaco : Calculadora
    {
        int numero1;
        int numero2;
        public Abaco()
        {
            Console.WriteLine(this.DireitosAutorais);
        }
        
        public int Subtrair()
        {
            return base.Subtrair(numero1, numero2);
        }
    }
}
