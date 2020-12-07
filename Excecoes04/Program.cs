using System;

namespace Excecoes04
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo t = new Calculo();
            try
            {
                t.Teste();
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }

    class Calculo
    {
        public void Teste()
        {
            try
            {
                int[] MeuVetor = new int[5];
                for (int contador = 0; contador <10; contador++)
                {
                    MeuVetor[contador] = contador;
                }
            }
            catch(Exception)
            {
                throw new Exception("Indice do array excede o tamanho do mesmo");
            }
        }
    }
}
