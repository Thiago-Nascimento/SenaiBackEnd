using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int cont = 1;
            
            Console.WriteLine("Exercicio 3");

            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            while(cont <= n) {
                
                Console.WriteLine($"{cont}: {cont*5}");
                
                cont ++;
            }
        }
    }
}
