using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 6");
            Console.WriteLine();

            int[] vetor3 = new int[10];
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];

            for(int i = 0; i < vetor1.Length; i++) {
                Console.Write("Digite um numero para o primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for(int i = 0; i < vetor2.Length; i++) {
                Console.Write("Digite um numero para o segundo vetor: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for(int i = 0; i < vetor1.Length; i++) {
                vetor3[i] = vetor1[i] + vetor2[i];
            }

            Console.Write("Terceiro Vetor: ");

            for(int i = 0; i < vetor3.Length; i++) {
                Console.Write($"{vetor3[i]}, ");
            }
        }
    }
}
