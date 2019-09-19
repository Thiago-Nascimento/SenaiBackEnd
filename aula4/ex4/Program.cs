using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;
            
            Console.WriteLine("Exercício 4");

            for(cont = 1; cont <= 100; cont++) {
                if((cont % 2) != 0) {
                    Console.WriteLine("Primeiro: " + cont);
                    // Console.Beep(8000, 100);
                }
            }

            for(cont = 100; cont >= 0; cont--) {
                if((cont % 2) != 0) {
                    Console.WriteLine("Segundo: " +cont);
                    // Console.Beep(8000, 100);
                }
            }
        }
    }
}
