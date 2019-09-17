using System;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            double pesoTerra, pesoPlaneta;
            int planeta;
            
            Console.WriteLine("Exercicio 9");
            Console.WriteLine();

            Console.Write("Digite seu peso: ");
            pesoTerra = double.Parse(Console.ReadLine());

            Console.Write("Digite o numero do planeta: ");
            planeta = int.Parse(Console.ReadLine());

            switch(planeta) {
                case 1:
                pesoPlaneta = pesoTerra * 0.37;
                Console.WriteLine($"Seu peso em Mercúrio é {pesoPlaneta}");
                break;

                case 2:
                pesoPlaneta = pesoTerra * 0.88;
                Console.WriteLine($"Seu peso em Vênus é {pesoPlaneta}");
                break;

                case 3:
                pesoPlaneta = pesoTerra * 0.38;
                Console.WriteLine($"Seu peso em Marte é {pesoPlaneta}");
                break;

                case 4:
                pesoPlaneta = pesoTerra * 2.64;
                Console.WriteLine($"Seu peso em Júpiter é {pesoPlaneta}");
                break;

                case 5:
                pesoPlaneta = pesoTerra * 1.15;
                Console.WriteLine($"Seu peso em Saturno é {pesoPlaneta}");
                break;

                case 6:
                pesoPlaneta = pesoTerra * 1.17;
                Console.WriteLine($"Seu peso em Urano é {pesoPlaneta}");
                break;
            }
        }
    }
}
