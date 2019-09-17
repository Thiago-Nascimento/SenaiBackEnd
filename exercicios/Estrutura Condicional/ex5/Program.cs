using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Exercicio 5");

            Console.Write("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num3 = int.Parse(Console.ReadLine());

            if(num1 == num2 && num1 == num3) {
                Console.WriteLine("Os numeros são iguais");
            } else if (num1 > num2 && num1 > num3) {
                Console.WriteLine($"{num1} é o maior numero");
            } else if (num2 > num1 && num2 > num3) {
                Console.WriteLine($"{num2} é o maior numero");
            } else if (num3 > num1 && num3 > num2) {
                Console.WriteLine($"{num3} é o maior numero");
            } else if (num1 == num2 && num3 > num1) {
                Console.WriteLine($"{num3} é o maior numero");
            } else if (num2 == num3 && num1 > num2) {
                Console.WriteLine($"{num1} é o maior numero");
            } else if (num3 == num1 && num2 > num1) {
                Console.WriteLine($"{num2} é o maior numero");
            }
        }
    }
}
