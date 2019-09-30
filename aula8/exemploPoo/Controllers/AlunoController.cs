using System;
using exemploPoo.Models;

namespace exemploPoo.Controllers
{
    public class AlunoController
    {
        AlunoModel al = new AlunoModel();
        
        public void ExibirAluno() {
            System.Console.WriteLine();
            System.Console.WriteLine("Nome: " + al.Nome);
            System.Console.WriteLine("Curso: " + al.Curso);
            System.Console.WriteLine("RA: " + al.RA);
            System.Console.WriteLine("Idade: " + al.Idade);
        }

        public void CadastrarAluno() {
            System.Console.WriteLine();

            System.Console.Write("Digite o nome do aluno: ");
            al.Nome =  Console.ReadLine();

            System.Console.Write("Digite o curso do aluno: ");
            al.Curso =  Console.ReadLine();

            System.Console.Write("Digite o RA do aluno: ");
            al.RA =  Console.ReadLine();

            System.Console.Write("Digite a idade do aluno: ");
            al.Idade =  int.Parse(Console.ReadLine());
        }        
        
        /// <summary>
        /// Escreve na tela "Tá na hora do café?"
        /// </summary>
        public void PedirIntervalo() {
            System.Console.WriteLine("Tá na hora do café?");
        }

        /// <summary>
        /// Escreve na tela "Ajuda ae Professor!"
        /// </summary>
        public void PedirAjuda() {
            System.Console.WriteLine("Ajuda ae Professor!");
        }
    }
}