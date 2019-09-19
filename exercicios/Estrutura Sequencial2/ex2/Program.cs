using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine("Exercicio 2");

            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"A tabuada do número {num} é: \n");

            for(int cont = 1; cont <= 10; cont++) {
                Console.WriteLine($"{num} X {cont} = {num*cont}");
            }
        }
    }
}
