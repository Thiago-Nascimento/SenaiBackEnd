using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor1 = new string[10];
            string[] vetor2 = new string[10];

            for(int i = 0; i < 10; i++) {
                Console.Write("Digite um nome de serie: ");
                vetor1[i] = Console.ReadLine();
            }

            Console.WriteLine();

            for(int i = 0; i < 10; i++) {
                vetor2[i] = vetor1[i];
            }

            for(int i = 0; i < 10; i++) {
                Console.WriteLine($"Indice {i} do vetor1: {vetor1[i]}");
            }
            
            Console.WriteLine();

            for(int i = 0; i < 10; i++) {
                Console.WriteLine($"Indice {i} do vetor2: {vetor2[i]}");
            }
        }
    }
}
