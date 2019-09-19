using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int populacao, popTotal = 0;
            int cont;

            Console.WriteLine("Exercício 1");

            for(cont = 1; cont <= 10; cont++) {
                Console.Write("Digite o número de pessoas da cidade: ");
                populacao = int.Parse(Console.ReadLine());

                popTotal = popTotal + populacao;
            }

            Console.WriteLine($"\nA população total é: {popTotal}");
        }
    }
}
