using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1menos = 0;
            int num = 0;
            int cont = 1;
            
            Console.WriteLine("Exercício 6");

            // for(int cont = 1; cont <= 20; cont++) {
            //     if((num1menos + num) == numSeq) {
            //         Console.WriteLine(numSeq);
            //         num1menos = numSeq;
            //     }
            //     num1menos = numSeq;
            //     num
            // }

            while(cont <= 20) {
                if(num == num + num1menos) {
                    Console.WriteLine(num);
                    num1menos = num;
                    cont++;
                }                                
                num++;
            }

        }
    }
}
