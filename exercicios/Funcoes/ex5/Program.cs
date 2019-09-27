using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = {23, 2, 65, 43, 24, 12};
            
            Console.WriteLine("Exercicio 5");

            Console.WriteLine(Soma(vetor));
        }

        static double Soma(double[] vetor) {
            double soma = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                soma = soma + vetor[i];
            }
            
            return soma;
        }
    }
}
