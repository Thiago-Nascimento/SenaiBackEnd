using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Um vendedor ganha 5% de comissão sobre suas vendas. Considere um
            // algoritmo que leia seu salário fixo, o total de vendas efetuadas e retorne o total
            // que vendedor irá receber.
            
            double salario, totalVendas, totalReceber;

            Console.WriteLine("Exercicio 3");
            Console.WriteLine();
            
            Console.Write("< Digite seu salário: ");
            salario = double.Parse(Console.ReadLine());

            Console.Write("< Digite o total de vendas: ");
            totalVendas = double.Parse(Console.ReadLine());

            totalReceber = salario + (totalVendas * 0.05);

            Console.WriteLine($"> O total a receber é de R${totalReceber}");
        }
    }
}
