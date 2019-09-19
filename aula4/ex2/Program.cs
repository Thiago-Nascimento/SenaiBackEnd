using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double altura, media;
            double altTotal = 0;
            int cont;
            
            Console.WriteLine("Exercicio 2");

            for(cont = 1; cont <= 15; cont++) {
                Console.Write("Escreva o nome da pessoa: ");
                nome = Console.ReadLine();

                Console.Write("Digite a altura da pessoa: ");
                altura = double.Parse(Console.ReadLine());

                altTotal = altTotal + altura;
            } 

            media = altTotal / 15;

            Console.WriteLine($"A altura média dessas pessoas é: {media}");
        }
    }
}
