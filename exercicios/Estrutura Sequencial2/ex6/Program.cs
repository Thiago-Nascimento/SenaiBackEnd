using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int contNum = 0;
            int num = 0;
            int penultimoNumero = 0;
            int ultimoNumero = 1;
            
            Console.WriteLine("Exercício 6 While");
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

            // //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // int contNum2 = 0;
            // int num2 = 0;
            // int penultimoNumero2 = 0;
            // int ultimoNumero2 = 1;

            // Console.WriteLine("\nExercício 6 For");
            // Console.WriteLine();

            // Console.WriteLine($"Fibonacci: {penultimoNumero2}");
            // Console.WriteLine($"Fibonacci: {ultimoNumero2}");

            // for(contNum2 = 0; contNum2 < 18; num2++) {
            //     if(num == (ultimoNumero + penultimoNumero)) {
            //         Console.WriteLine($"Fibonacci: {num2}");

            //         penultimoNumero2 = ultimoNumero2;
            //         ultimoNumero2 = num2;
                    
            //         contNum2++;
            //     }
            // }
            // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // int contNum3 = 0;
            // int num3 = 0;
            // int penultimoNumero3 = 0;
            // int ultimoNumero3 = 1;
            
            // Console.WriteLine("\nExercício 6 Do While");
            // Console.WriteLine();

            // Console.WriteLine($"Fibonacci: {penultimoNumero3}");
            // Console.WriteLine($"Fibonacci: {ultimoNumero3}");

            //  do {
            //     if(num3 == (ultimoNumero3 + penultimoNumero3)) {
            //         Console.WriteLine($"Fibonacci: {num3}");

            //         penultimoNumero3 = ultimoNumero3;
            //         ultimoNumero3 = num3;
                    
            //         contNum3++;
            //     }
            //     num3++;
            // } while(contNum3 < 18);
        }
    }
}
