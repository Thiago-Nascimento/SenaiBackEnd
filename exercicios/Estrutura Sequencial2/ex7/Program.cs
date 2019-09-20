using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int soma = 0;
            int produto = 0;
            
            Console.WriteLine("Exercicio 7");
            Console.WriteLine();

            for(int contNumeros = 1; contNumeros <= 100; contNumeros++) {
                Console.Write("Digite um numero inteiro maior que zero: ");
                num = int.Parse(Console.ReadLine());

                if(num % 2 != 0) {
                    soma = soma + num;
                }
                
                if ((num % 3 == 0) && (produto == 0)) {
                    produto = num;
                } else if (num % 3 == 0) {
                    produto = produto * num;
                } 
            }

            Console.WriteLine($"A soma dos números impares é: {soma}");
            Console.WriteLine($"O produtos dos números múltiplos de 3 é: {produto}");
        }
    }
}
