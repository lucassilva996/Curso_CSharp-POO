using System;

/// <summary>
/// Classe Abstrata é a classe que possui o modificador abstract
/// o modificador abstract indica que a classe não pode ser instanciada
/// ela é uma classe q é a ser base para outras classes
/// pode ter métodos abstratos e não abstratos
/// método abstrato não tem corpo, apenas assiantura: public abstract void Metodo1(){};
/// a implementação do método abstrato na classe derivada usa-se override: public override void Metodo1(){};
/// </summary>

namespace Abstrata01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teste t = new Teste();

        }
    }

    public abstract class Teste
    {
        public string nome = "Lucas";
        public void Metodo1()
        {
            Console.WriteLine("Classe abstrata");
        }

        public abstract void Metodo2();
        public string Idade { get; set; }
    }

    public class Derivada : Teste
    {

        public override void Metodo2()
        {
            throw new NotImplementedException();
        }
    }
}
