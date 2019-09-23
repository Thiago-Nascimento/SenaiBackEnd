using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 4");
            Console.WriteLine();

            string[] vetor1 = new string[15];
            string[] vetor2 = new string[15];
            string[] vetor3 = new string[30];

            for(int i = 0; i < vetor1.Length; i++) {
                Console.Write("Digite uma palavra para o primeiro vetor: ");
                vetor1[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for(int i = 0; i < vetor2.Length; i++) {
                Console.Write("Digite uma palavra para o segundo vetor: ");
                vetor2[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for(int i = 0; i < vetor1.Length; i++) {
                vetor3[i] = vetor1[i];
                vetor3[i + vetor1.Length] = vetor2[i];
            }

            Console.Write("Terceiro Vetor: ");

            for(int i = 0; i < vetor3.Length; i++) {
                Console.Write($"{vetor3[i]}, ");
            }
        }
    }
}
