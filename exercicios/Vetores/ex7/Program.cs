using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[3];
            int maior = 0;
            int indice = 0;           
            
            Console.WriteLine("Exercicio 7 ");
            Console.WriteLine();

            for(int i = 0; i < vetor.Length; i++) {
                Console.WriteLine("Digite um número: ");
                vetor[i] = int.Parse(Console.ReadLine());

                if(vetor[i] > maior) {
                    maior = vetor[i];
                    indice = i;
                }
                
                if(vetor[0] < 0 && maior == 0) {
                    maior = vetor[0];
                }
            }
            
            Console.WriteLine(maior);
            Console.WriteLine(indice);
        }
    }
}
