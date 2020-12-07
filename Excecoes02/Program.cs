using System;
using System.IO;

namespace Excecoes02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //rotinas a serem executadas na aplicação
                Console.WriteLine("Informe um numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                int resultado = 100 / numero;
                Console.WriteLine("O resultado é: ", resultado);
            }
            catch (FormatException)
            {
                //bloco executado caso ocorra algum erro
                Console.WriteLine("Formato de número inválido");
            }
            catch (DivideByZeroException)
            {
                //bloco executado caso ocorra algum erro
                Console.WriteLine("O número não pode ser zero!");
            }
            catch (Exception ex)
            {
                //bloco executado caso ocorra algum erro
                Console.WriteLine("Não existe divisão por zero " + ex.Message);
            }
            
                Console.ReadKey();

        }


    }
}
