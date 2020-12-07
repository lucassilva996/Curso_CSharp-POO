using System;

namespace Excecoes01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o valor de numero 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de numero 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            try
            {
                //rotinas a serem executadas na aplicação
                int resultado = num1 / num2;
                Console.WriteLine("{0} / {1} = {2}", num1, num2, resultado);
            }
            catch (Exception ex)
            {
                //bloco executado caso ocorra algum erro
                Console.WriteLine("Não existe divisão por zero " + ex.Message);
            }
            finally
            {
                //bloco sempre executado no final
                //(liberar rescursos / fechar arquivos / encerrar o programa, etc..)
                Console.WriteLine("Executei o codigo do bloco finally");
                Console.ReadKey();
            }
            
            

        }
    }
}

