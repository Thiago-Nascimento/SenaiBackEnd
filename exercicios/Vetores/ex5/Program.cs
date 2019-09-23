using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            
            Console.WriteLine("Exercicio 5");

            for(int i = 0; i < vetor.Length; i++) {
                vetor[i] = i*2;
            }

            for(int i = 0; i < vetor.Length; i++) {
                Console.Write($"{vetor[i]} ");
            }
        }
    }
}
