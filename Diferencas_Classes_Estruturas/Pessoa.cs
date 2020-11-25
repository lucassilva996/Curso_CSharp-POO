using System;

namespace Diferencas_Classes_Estruturas
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        
        public Pessoa()
        {
            Nome = "Lucas";
            Sobrenome = "Silva Lima";
        }

        public string Pessoa(string _nome, string _sobrenome)
        {
            Nome = _nome;
            Sobrenome = _sobrenome;
        }
        //protected indica que o membro pode ser acessado 
        //nessa classe e em outras classes que herdam da classe
        protected void NomeCompleto()
        {
            Console.WriteLine(Nome + " " + Sobrenome);
        }
        
    }
}
