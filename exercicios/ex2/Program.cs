using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elabore um algoritmo que leia o preço de custo de uma mercadoria e um
            // percentual de acréscimo para exibição do valor de venda desta mercadoria.
            
            double precoCusto, percAcrescimo, valorVenda;

            Console.WriteLine("Exercicio 2");
            Console.WriteLine();

            Console.Write("< Digite o preco de custo da mercadoria: ");
            precoCusto = double.Parse(Console.ReadLine());

            Console.Write("< Digite o percentual de acrescimo: ");
            percAcrescimo = double.Parse(Console.ReadLine());

            valorVenda = precoCusto + ((percAcrescimo / 100) * precoCusto);

            Console.WriteLine();
            Console.WriteLine($"> O valor de venda será de R${valorVenda}");
        }
    }
}
