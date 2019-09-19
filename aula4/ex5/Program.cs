using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo 5");

            double nota = 0;
            double ac = 0;
            int cont = 0;
            string sair = "";

            while(sair != "sim") {
                Console.WriteLine("Digite a nota do aluno: ");
                nota = double.Parse(Console.ReadLine());

                ac += nota;
                cont++;

                Console.WriteLine("Deseja Sair da Aplicação? sim/nao ");
                sair = Console.ReadLine().ToLower();
            }           
            
            Console.WriteLine($"Média das notas: {ac/cont}");
        }
    }
}
