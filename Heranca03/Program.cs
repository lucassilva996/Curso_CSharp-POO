using System;

namespace Heranca03
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    public class ClasseBase
    {
        //declarando um método que pode ser sobrescrito
        public ClasseBase()
        {
            Console.WriteLine("Construtor da classe base"); //2
        }
    }

    public class ClasseDerivada : ClasseBase
    {
        public string nome = "Lucas Silva Lima"; //1
        public int idade = 24; //1

        public ClasseDerivada()  //3
        {
            Console.WriteLine("\nConstrutor da classe derivada");
        }
    }

}
