using System;

namespace ProjetoFatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var fatorial = new Fatorial();
            var resultado = fatorial.CalculoIterativo(5);
            Console.WriteLine(resultado);

            resultado = fatorial.CalculoRecursivo(5);
            Console.WriteLine(resultado);
        }
    }
}
