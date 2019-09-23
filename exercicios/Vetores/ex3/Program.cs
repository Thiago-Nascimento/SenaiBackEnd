using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeProduto = new string[12];
            string[] cor = new string[12];
            string[] tamanho = new string[12];
            double[] preco = new double[12];
            
            Console.WriteLine("Exercicio 3");
            Console.WriteLine();

            for(int i = 0; i < 12; i++) {
                Console.Write("Digite o nome do produto: ");
                nomeProduto[i] = Console.ReadLine();

                Console.Write("Digite a cor do produto: ");
                cor[i] = Console.ReadLine();

                Console.Write("Digite o tamanho do produto: ");
                tamanho[i] = Console.ReadLine();

                Console.Write("Digite o preço do produto: ");
                preco[i] = double.Parse(Console.ReadLine());
            }

            for(int i = 0; i < nomeProduto.Length; i++) {
                Console.WriteLine();
                Console.Write($"Produto {i+1}: {nomeProduto[i]}, {cor[i]}, {tamanho[i]}, R${preco[i]}");
            }
        }
    }
}
