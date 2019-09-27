using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = {23, 2, 65, 43, 24, 12};

            Console.WriteLine("Exercicio 5");

            Console.WriteLine(MaiorNumero(vetor));
        }

        static double MaiorNumero(double[] vetor) {
            double maior = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                if(i == 0) {
                    maior = vetor[0];
                } 
                
                if (vetor[i] > maior) {
                    maior = vetor[i];
                }
            }
            
            return maior;
        }
    }
}
