using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            string classificacao;

            Console.WriteLine("Exercicio 6");

            Console.Write("Insira a idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade > 18) {
                classificacao = "Adults Only +18";
            } else if (idade > 17) {
                classificacao = "Mature +17";
            } else if (idade > 13) {
                classificacao = "Teen +13";
            } else if (idade > 10) {
                classificacao = "Everyone +10";
            } else if (idade < 3) {
                classificacao = "Early Childhood";
            } else {
                classificacao = "Everyone";
            }

            Console.WriteLine(classificacao);
        }
    }
}
