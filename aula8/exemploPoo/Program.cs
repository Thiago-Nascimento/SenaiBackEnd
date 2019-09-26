using System;
using exemploPoo.Models;

namespace exemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoModel aluno = new AlunoModel();

            System.Console.Write("Digite o nome do aluno: ");
            aluno.Nome =  Console.ReadLine();
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
