using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            
            Console.WriteLine("Exercicio 1");
            Console.WriteLine();

            for(int cont = 0; cont <= 9; cont++) {
                Console.Write("Digite um número: ");
                vetor[cont] = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine($"Ultima posição multiplicada por 5: {(vetor[9] * 5)}");
        }
    }
}
