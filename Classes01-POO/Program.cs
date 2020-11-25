using System;

namespace Classes01_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //instância do objeto carro
            Carro fusca;
           fusca = new Carro("Preto");
           fusca.Cor = "Azul";
           Console.WriteLine(fusca.Descricao());
           Console.ReadKey();     
        }
    }

    //definição da classe
    class Carro
        {
          //atributo
        private string _cor;
        //   //metodo ou comportamento
       public string Cor
           {
              //get - sempre retorna o valor da variavel
              //set - sempre atribui o valor da variavel

               //notação atual 
               //public string Cor {get; set;}

              //notação antiga
                get {return _cor;}
                set {_cor = value;}

          }



          //metodo ou comportamento
          public string Descricao()
          {
              return "O carro é: " + _cor;
          } 

          public string Descricao(string texto)
          {
              return "O carro é: " + texto;
          } 
//construtor - método especial usado quando a classe for instanciada (criação de objetos);
//Não deve retornar nenhum tipo ou valor;
//Podem ser sobrecarregados ou seja, podemos ter mais de um construtor com o mesmo nome mas com assinaturas diferentes;

        //construtor com parametro(argumento)
        public Carro (string cor)
        {
            this.Cor = cor;
        }

        //construtor sem parametro(argumento)
        public Carro()
        {

        }
//destrutor - metódo especial usado para destruir a instância de uma classe;
//Não pode ser chamado diretamente. São invocados automaticamente.
//Não tem modificadores, nem parametros;
//Não podem ser herdados nem sobrecarregados;
//ele é chamado quando o Garbage Collector faz a coleta do objeto
    }
}