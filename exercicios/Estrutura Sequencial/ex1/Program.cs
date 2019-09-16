using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo para solicitar ao
            // usuário um número, calcular e mostrar o seu triplo.
            
            int numero, triplo;

            Console.WriteLine("Exercicio 1");
            Console.WriteLine();

            Console.Write("< Digite um numero inteiro: ");
            numero = int.Parse(Console.ReadLine());

            triplo = numero * 3;

            Console.WriteLine($"> O triplo de {numero} é {triplo}");
        }
    }
}
