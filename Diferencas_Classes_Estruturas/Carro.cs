using System;

namespace Diferencas_Classes_Estruturas
{
    public struct Carro
    {
        public string cor;
        public string Cor 
        {
            get {return cor;}
            set {cor = value;}
        }
        public string modelo;
        public string Modelo
        {
            get {return modelo;}
            set {modelo = value;}    
        }

        //construtor sem parametro (argumento)
        public Carro()
        {
            this.cor = "Verde";
        }

        //construtor com parametro (argumento)
        public Carro(string modelo, string cor)
        {
            this.modelo = modelo;
            this.cor = cor;
        }

        public string Descricao()
        {
            return "Carro: " + Modelo + " Cor: " + Cor;
        }
    }
}
