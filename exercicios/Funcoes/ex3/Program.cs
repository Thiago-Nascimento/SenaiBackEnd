using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            double idade, peso, altura;
            
            Console.WriteLine("Exercicio 3");

            #region SemArgumentos
                Console.WriteLine("Mostra Info sem argumentos: ");
                MostraInfo();
            #endregion

            #region DoisArgumentos
                Console.WriteLine("Mostra Info com dois argumentos: ");

                Console.Write("Digite um nome: ");
                nome = Console.ReadLine();

                Console.Write("Digite o sobrenome: ");
                sobrenome = Console.ReadLine();

                Console.WriteLine(MostraInfo(nome, sobrenome));  
                Console.WriteLine();              
            #endregion

            #region TresArgumentos
                Console.WriteLine("Mostra Info com tres argumentos: ");

                Console.Write("Digite sua idade: ");
                idade = double.Parse(Console.ReadLine());

                Console.Write("Digite seu peso: ");
                peso = double.Parse(Console.ReadLine());

                Console.Write("Digite sua altura: ");
                altura = double.Parse(Console.ReadLine());

                foreach (double dado in MostraInfo(idade, peso, altura))
                {
                    Console.Write($"{dado}\n");
                }                
                Console.WriteLine();
            #endregion
        }

        static void MostraInfo() {
            Console.WriteLine("Escola SENAI de Informática");
            Console.WriteLine();
        }

        static string MostraInfo(string nome, string sobrenome) {
            string nomeCompleto;
            nomeCompleto = nome + " " + sobrenome;            
            return nomeCompleto;
        }

        static double[] MostraInfo(double idade, double peso, double altura) {
            double[] dados = {idade, peso, altura};            
            return dados;
        }
    }
}
