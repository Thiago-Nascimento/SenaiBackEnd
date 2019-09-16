using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sabendo que uma pessoa recebe um salário fixo por mês e que ele tem contas
            // a pagar, faça um algoritmo que leia o salário que ela recebe por mês e leia
            // também a dívida que possui. Por fim calcule e escreva quanto vai sobrar do
            // salário dela depois de pagar a dívida.
            
            double salario, divida, restante;

            Console.WriteLine("Exercicio 6");
            Console.WriteLine();

            Console.Write("< Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("< Digite seu total de dívidas: ");
            divida = double.Parse(Console.ReadLine());

            restante = salario - divida;

            Console.WriteLine($"> Se pagar o total de suas dívidas, terá R${restante} restantes");

        }
    }
}
