using System;



namespace ClassesStatic01
{
    class Program
    {
        static void Main(string[] args)
        {

            //uma instância da classe livro
            Livro livro1 = new Livro();

            livro1.Titulo = "Use a cabeça! C#";
            livro1.Autor = "Andrew Stellman";

            Console.WriteLine("Primeiro Livro");
            Console.WriteLine("Titulo: " + livro1.Titulo);
            Console.WriteLine("Autor: " + livro1.Autor);

            //uma instância da classe livro
            Livro livro2 = new Livro();

            livro2.Titulo = "Programação de Computadores com C#";
            livro2.Autor = "José Augusto N. G. Manzano";
            
            Console.WriteLine("\n");
            Console.WriteLine("Segundo Livro");
            Console.WriteLine("Titulo: " + livro2.Titulo);
            Console.WriteLine("Autor: " + livro2.Autor);

            Console.ReadKey();
        }
    }

    //Cada uma das instâncias da classe lhe da acesso aos membros da classe
    //mas cada instância trata os valores particulares dos membros de sua instância
    public class Livro
    {
        public string Titulo;
        public string Autor;
    }
}
