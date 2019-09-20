using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int contNum = 0;
            int num = 0;
            int ultimoNumero = 1;
            int penultimoNumero = 0;
            
            Console.WriteLine("Exercício 6");
            Console.WriteLine();

            Console.WriteLine($"Fibonacci: {penultimoNumero}");
            Console.WriteLine($"Fibonacci: {ultimoNumero}");

            while(contNum < 18) {
                if(num == (ultimoNumero + penultimoNumero)) {
                    Console.WriteLine($"Fibonacci: {num}");

                    penultimoNumero = ultimoNumero;
                    ultimoNumero = num;
                    
                    contNum++;
                }
                num++;
            }
        }
    }
}
