using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int media;
            int soma = 0;
            int contNegativos = 0;
            int cont = 1;

            
            Console.WriteLine("Exercício 4");

            do {
                Console.WriteLine("Digite um número inteiro: ");
                num = int.Parse(Console.ReadLine());

                if(num >= 0) {
                    Console.WriteLine($"Numero não negativo: {num}");
                } else {
                    soma = soma + num;
                    contNegativos++;
                }
                
                cont++;
            } while(cont <= 20);

            media = soma / contNegativos;

            Console.WriteLine($"A média dos numeros negativos é: {media}");
        }
    }
}
