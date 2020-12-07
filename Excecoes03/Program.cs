using System;

namespace Excecoes03
{
    class Program
    {
        static void Main(string[] args)
        {
            string Lucas = null;

            if(Lucas == null)
            {
                throw new ArgumentException();
            }

            Console.WriteLine("A string Lucas é NULL"); //não será executada
        }
    }
}
