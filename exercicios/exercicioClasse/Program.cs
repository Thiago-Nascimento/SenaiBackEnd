using System;
using exercicioClasse.Controllers;

namespace exercicioClasse
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaControllers pessoa1 = new PessoaControllers();

            pessoa1.CadastraPessoa();
            Console.WriteLine();
            pessoa1.ExibirPessoa();
            Console.WriteLine();
            pessoa1.CalculaIMC();
        }
    }
}
