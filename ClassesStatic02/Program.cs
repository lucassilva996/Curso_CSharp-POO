using System;

//Classes(Static)
//1. Não pode ser instânciada;
//2. Podem ter somente membros estáticos;
//3. Pode ser acessado pelo nome da classe;
//4. Não pode ser herdada;
//5. Contém apenas construtores estaticos
//6. Não pode ter construtores de instância
//7. Possui a palavra-chave "static" como modificador;
//8. Construtores estáticos são chamados apenas uma vez;
//9. Possui somente construtores privados;

namespace ClassesStatic02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma: " + Calculadora.Somar(7, 2).ToString());
            Console.WriteLine("Subtração: " + Calculadora.Subtrair(7, 2).ToString());
            int resultado = Calculadora.Multiplicar(7, 2);
            Console.WriteLine("Multiplicação = " + resultado);
            Console.WriteLine("Divisão = " + Calculadora.Dividir(7, 2).ToString());
            Console.Read();
        }
    }
}
