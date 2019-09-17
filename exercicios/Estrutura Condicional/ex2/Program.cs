using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoPagar;
            
            Console.WriteLine("Exercicio 2");

            Console.Write("Digite o preço a pagar: ");
            precoPagar = double.Parse(Console.ReadLine());

            if(precoPagar > 100) {
                precoPagar = precoPagar - 25;
            }

            Console.WriteLine($"Total a pagar: {precoPagar}");
        }
    }
}
