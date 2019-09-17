using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, despesa, saldo;

            Console.WriteLine("Exercicio 1");

            Console.Write("Digite seu salario: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de suas despesas: ");
            despesa = double.Parse(Console.ReadLine());

            saldo = salario - despesa;

            Console.WriteLine($"Saldo: {saldo}");

            if(saldo >= 0) {
                Console.WriteLine("Seu saldo é POSITIVO");
            } else {
                Console.WriteLine("Seu saldo é NEGATIVO");
            }

        }
    }
}
