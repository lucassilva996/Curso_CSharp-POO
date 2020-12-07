using System;

namespace Heranca02
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaClasseDerivada cderivada = new MinhaClasseDerivada();
            MinhaClasseBase cbase = (MinhaClasseBase)cderivada;
            //
            cderivada.Imprimir(); //chama o método imprimir da parte da classe derivada
            Console.WriteLine(cderivada.Idade);
            //cbase.Imprimir();//chama o método imprimir da parte da classe base            
            Console.ReadKey(); 
        }
    }
    public class MinhaClasseBase
    {
        private int _idade = 15;
        //virtual - determina que um membro pode ser sobrescrito em uma classe derivada
        //override - determina que na classe derivada um membro vritual da base pode ser sobrescrito
        //ambas as declarações se complementam
        public virtual int Idade
        {
            get { return _idade; }
        }
        public virtual void Imprimir()
        {
            Console.WriteLine("Eu sou método da classe base");
        }
    }

    public class MinhaClasseDerivada : MinhaClasseBase
    {
        public string status = "Classe derivada OK";

        private int _idade = 25;
        public override int Idade
        {
            get { return _idade;  }
        }

        public override void Imprimir()
        {
            Console.WriteLine("Eu sou o método da classe derivada");
        }
    }
}
