using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            
            Console.WriteLine("Exercicio 1");

            do {
                Console.WriteLine($"{cont}³ = {Math.Pow(cont, 3)}");                
                cont++;
            } while(cont <= 100);
        }
    }
}
