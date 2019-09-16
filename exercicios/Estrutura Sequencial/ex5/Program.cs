using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que leia o nome de um vendedor, o seu salário fixo e o
            // total de vendas efetuadas por ele no mês (em dinheiro). O vendedor ganha 10%
            // de comissão sobre suas vendas efetuadas. Exiba, o nome, o salário fixo e salário
            // final do mês do vendedor.

            string nomeVendedor;
            double salarioFixo, totalVendas, salarioFinal;            
            
            Console.WriteLine("Exercicio 5");
            Console.WriteLine();

            Console.Write("< Olá vendedor, digite seu nome: ");
            nomeVendedor = Console.ReadLine();

            Console.Write("< Agora digite seu salário: ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("< Agora o total de vendas realizadas: ");
            totalVendas = double.Parse(Console.ReadLine());

            salarioFinal = salarioFixo + (0.1 * totalVendas);

            Console.WriteLine($"> {nomeVendedor}, seu salário fixo é de R${salarioFixo}, e seu sálario final esse mês será de R${salarioFinal}");
        }
    }
}
