using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2");
            Console.WriteLine();

            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetor3 = new int[20];

            for(int i = 0; i < 10; i++) {
                Console.Write("Digite um número para o primeiro vetor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for(int i = 0; i < 10; i++) {
                Console.Write("Digite um número para o segundo vetor: ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for(int i = 0; i < 10; i++) {
                vetor3[i] = vetor1[i];
                vetor3[i + 10] = vetor2[i];
            }

            Console.Write("Terceiro Vetor: ");

            for(int i = 0; i < 20; i++) {
                Console.Write($"{vetor3[i]}, ");
            }
        }
    }
}
