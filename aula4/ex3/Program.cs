using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, cont, mais50;
            mais50 = 0;
            
            Console.WriteLine("Exercicio 3");

            for(cont = 1; cont <= 10; cont++) {
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());

                if(idade > 50) {
                    mais50 = mais50 + 1;
                }
            }

            Console.WriteLine($"O número de pessoas com mais de 50 anos é: {mais50}");
        }
    }
}
