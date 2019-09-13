using System;

namespace aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Somente declaração
            int numero1;

            // Declaração e atribuição de valor
            int numero2 = 5;

            // Declaração de varias variaveis
            int numero3, numero4, numero5;

            float media;

            // Tipo booleano
            bool resultado = false;

            string nomeAluno;

            Console.WriteLine("Bem Vindos a nossa primeira aplicação!");

            Console.Write("Digite seu nome: ");
            nomeAluno = Console.ReadLine();

            Console.WriteLine(nomeAluno + ", agora digite sua primeira nota: ");
            // numero3 = Convert.ToInt32(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());

            // Interpolação
            Console.WriteLine($"Sua primeira nota é {numero3}");

            Console.Write("Digite sua segunda nota: ");
            numero4 = int.Parse(Console.ReadLine());

            Console.Write("Digite sua terceira nota: ");
            numero5 = int.Parse(Console.ReadLine());

            media = (numero3 + numero4 + numero5) / 3;

            Console.WriteLine($"Sua média é {media}");
        }
    }
}
