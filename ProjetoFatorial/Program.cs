using System;

namespace ProjetoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var fatorial = new Fatorial();
            var resultado = fatorial.CalcularFatorial(5);
            Console.WriteLine(resultado);
        }
    }
}
