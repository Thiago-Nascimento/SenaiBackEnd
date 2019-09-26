using System;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            
            try {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());
            }
            catch(Exception ex) {
                Console.WriteLine($"ERRO: {ex}");
            }           


        }
    }
}
