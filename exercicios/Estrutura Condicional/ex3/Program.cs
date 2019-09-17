using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            
            Console.WriteLine("Exercicio 3");

            Console.Write("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 == num2) {
                Console.WriteLine("Os numeros são iguais");
            } else if (num1 > num2) {
                Console.WriteLine($"{num1} é maior que {num2}");
            } else {
                Console.WriteLine($"{num2} é maior que {num1}");
            }
        }
    }
}
