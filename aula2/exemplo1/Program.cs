using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.Write("Digite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a primeira nota: ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            if(media >= 6) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
            }
        }
    }
}
