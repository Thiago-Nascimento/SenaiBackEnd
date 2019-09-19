using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio");

            int num;
            int m3 = 0;
            int cont = 1;

            do {
                Console.Write("Digite o número: ");
                num = int.Parse(Console.ReadLine());
                
                if(num % 3 == 0) {
                    m3 = m3 + num;
                }
                
                cont++;
            } while(cont<=20);

            Console.Write($"Total: {m3}");
        }
    }
}
