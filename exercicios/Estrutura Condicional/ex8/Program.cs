using System;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string pedido;
            
            Console.WriteLine("Exercicio 8");
            Console.WriteLine();

            Console.Write("Digite o número do pedido: ");
            pedido = Console.ReadLine();

            switch(pedido) {
                case "1":
                Console.WriteLine("Hamburguer");
                break;

                case "2":
                Console.WriteLine("Cheese Salada");
                break;

                case "3":
                Console.WriteLine("Cheese Burguer");
                break;

                case "4":
                Console.WriteLine("Cheese Bacon");
                break;

                default:
                Console.WriteLine("Opção Inválida");
                break;
            }
        }
    }
}
