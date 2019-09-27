using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, porcentagem;

            Console.WriteLine("Exercicio 1");

            Console.Write("Digite o valor: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Digite a porcentagem de desconto: ");
            porcentagem = double.Parse(Console.ReadLine());

            Console.WriteLine($"O valor com desconto é: R${AtribuiDesconto(valor, porcentagem)}");
        }

        /// <summary>
        /// Funcao que atribui desconto a um valor
        /// </summary>
        /// <param name="valorTotal">double</param>
        /// <param name="porcentagemDesconto">double</param>
        /// <returns>double Valor com o desconto aplicado</returns>
        static double AtribuiDesconto(double valorTotal, double porcentagemDesconto) {
            double valorFinal;            
            valorFinal = valorTotal - (valorTotal * (porcentagemDesconto/100));
            
            return valorFinal;
        }
    }
}
