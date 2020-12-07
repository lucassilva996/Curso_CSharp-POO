using System;

namespace ClassesStatic03
{
    class Program
    {
        static void Main(string[] args)
        {
            Teste t1 = new Teste();
            Teste t2 = new Teste();

            Console.WriteLine("Atribuindo t1.A = 5, t1.B = 5:");
            t1.A = 5;
            t1.B = 5;

            Console.WriteLine("t1.A = {0}, t1.B = {1}", t1.A, t1.B);
            Console.WriteLine("t2.A = {0}, t2.B = {1}", t2.A, t2.B);
            Console.ReadKey();
            t2.A = 9;
            t2.B = 9;
            Console.WriteLine("Atribuindo t2.A = 9, t2.B = 9:");
            Console.WriteLine("t1.A = {0}, t1.B = {1}", t1.A, t1.B);
            Console.WriteLine("t2.A = {0}, t2.B = {1}", t2.A, t2.B);
            Console.ReadKey();



        }
    }

    public class Teste
    {
        static int a = 0;
        int b = 0;

        public int A
        {
            get { return a; }
            set { a = value; }
        }
        public int B
        {
            get { return b; }
            set { b = value; }
        }

    }
}
