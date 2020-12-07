using System;

//#Classe - Representa um modelo ou template de uma entidade real que desejamos tratar
//#Objetos - São instâncias das classes;
//#Em C# para criar uma instância(objeto) de uma classe usamos a palavra-chave new;
//#Classe é constituida por: Propridades, Construtores e Metódos
//#Classes utilizam tipos por referência


//#Herança - Permite criar novas classes que reutilizem, estendam e modifiquem um comportamento que é definido em uma classe ja existente
//#Herança foi criada para organizar e reutilizar código;
//# A classe que é herdada é chamda de: CLASSE BASE, Classe Pai, Classe Mãe, Super Classe
//#A classe que herda é chamada de: CLASSE DERIVADA, Classe filha, Sub Classe

namespace Heranca01
{
    class Program
    {
        static void Main(string[] args)
        {
            //PessoaFisica Lucas = new PessoaFisica();
            //Lucas.nome = "Lucas da Silva Lima";
                        
            //PessoaJuridica Lucdslisoft = new PessoaJuridica();
            //Lucdslisoft.endereco = "Estrada Presidente Juscelino Kubts....";

            Aluno Joao = new Aluno();
            Joao.matricula = "123456";
            Console.WriteLine(Joao.Descricao());
            Console.WriteLine(Joao.Mostrar());
            Console.WriteLine("Criei uma instância da classe aluno!");
            Console.ReadKey();
        }
    }
   
    class Pessoa
    {
        public string nome { get; set; }
        public string endereco { get; set; }

        public Pessoa()
        {
            Console.WriteLine("Construtor da Classe Pessoa");
        }
    }

    class PessoaFisica : Pessoa
    {
        //public string cpf { get; set; }
        //public string rg { get; set; }


        public PessoaFisica()
        {
            Console.WriteLine("Construtor da Classe Pessoa Fisica");
        }

        public string Descricao()
        {
            return "Sou o método Descrição da clase PessoaFísica";
        }
    }

    //class PessoaJuridica : Pessoa
    //{
    //    public string cnpj { get; set; }
    //    public string inscEstadual { get; set; }
    //}

    class Aluno : PessoaFisica
    {
        public string matricula;
    
        public Aluno()
        {
            Console.WriteLine("Construtor da Classe Aluno");
        }

        //Ocultação de método - oculta o método de qualquer classe
        new public string Descricao()
        {
            return "Sou o método Descrição da clase Aluno";
        }

        //para mostrar o método
        public string Mostrar()
        {
            return base.Descricao();
        }
    }

}
