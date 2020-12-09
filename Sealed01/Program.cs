using System;

namespace Sealed01
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
        }
    }

    public sealed class Teste
    {
        public void Metodo1()
        {
        }
    }

    //public class Derivada : Teste
    //{
    //    public override void Metodo2()
    //    {
    //    }
    //}
}
