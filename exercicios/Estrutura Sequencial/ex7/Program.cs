using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            // O preço do vale transporte é de R$4,30. O motorista de um ônibus deseja
            // adquirir um programa que leia a quantidade de passageiros que entram no
            // ônibus e que depois calcule e escreva quanto de dinheiro ele terá arrecadado.
            // Considere que todos os passageiros irão pagar o vale transporte sem
            // descontos.

            int passageiros;
            double total;            
            
            Console.WriteLine("Exercicio 7");
            Console.WriteLine();

            Console.Write("< Quantidade de passageiros: ");
            passageiros = int.Parse(Console.ReadLine());

            total = passageiros * 4.3;

            Console.WriteLine($"> O total arrecadado foi de R${total}");
        }
    }
}
