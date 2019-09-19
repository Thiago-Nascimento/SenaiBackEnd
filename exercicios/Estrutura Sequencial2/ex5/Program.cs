using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFuncionarios;
            double salario;
            double somaSalarios = 0;
            int cont = 1;
            
            Console.WriteLine("Exercício 5");

            Console.Write("Digite o número de funcionários: ");
            numFuncionarios = int.Parse(Console.ReadLine());

            while(cont <= numFuncionarios) {
                Console.Write("Digite o salário: ");
                salario = double.Parse(Console.ReadLine());

                somaSalarios = somaSalarios + salario;
                
                cont++;
            }

            Console.WriteLine($"A média dos salários é: {somaSalarios / numFuncionarios}");
        }
    }
}
