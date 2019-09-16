using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elabore um algoritmo que efetue a apresentação da conversão de um valor em
            // real (R$) para o valor em dólar (US$). O algoritmo deverá solicitar o valor da
            // cotação do dólar.
            
            double valorReal, valorDolar, cotacaoDolar;
            
            Console.WriteLine("Exercicio 4");
            Console.WriteLine();

            Console.Write("< Digite o valor em Reais: ");
            valorReal = double.Parse(Console.ReadLine());

            Console.Write("< Digite a cotação do Dólar: ");
            cotacaoDolar = double.Parse(Console.ReadLine());

            valorDolar = valorReal / cotacaoDolar;

            Console.WriteLine($"> O valor em Dólar é ${valorDolar}");
        }
    }
}
