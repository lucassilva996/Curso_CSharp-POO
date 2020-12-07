using System;

namespace Excecoes05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            if(idade < 18)
            {
                throw new ExceptionIdadeInvalida("Idade mínima: 18 anos");
            }
            Console.ReadKey();
        }
    }
    public class ExceptionIdadeInvalida : ApplicationException
    {
        public ExceptionIdadeInvalida(string message)
            : base(message)
        { }
    }
}
