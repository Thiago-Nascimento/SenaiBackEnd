using System;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] media = new double[10];

            for(int cont = 0; cont < 10; cont++) {
                Console.Write("Digite uma média: ");
                media[cont] = double.Parse(Console.ReadLine());
            }

            for(int cont = 0; cont < media.Length; cont++) {
                Console.WriteLine(media[cont]);
            }           
        }
    }
}
