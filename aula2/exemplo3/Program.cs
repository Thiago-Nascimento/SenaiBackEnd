using System;

namespace exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            bool entrada = false;
            string resposta;

            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            if(idade > 17) {
                entrada = true;
            }

            if(entrada == true) {
                resposta = "Entrada Permitida";
            } else {
                resposta = "Entrada Negada";
            }

            Console.WriteLine(resposta);
        }
    }
}
