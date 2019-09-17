using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double precoPagar;

            Console.WriteLine("Exercicio 4");

            Console.Write("Digite o valor a ser pago: ");
            precoPagar = double.Parse(Console.ReadLine());

            if(precoPagar > 100 && precoPagar < 1000) {
                precoPagar = precoPagar - (0.15 * precoPagar);
            }

            Console.WriteLine($"O total a pagar é: {precoPagar}");
        }
    }
}
