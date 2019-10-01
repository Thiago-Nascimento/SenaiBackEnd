using System;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class AlunoControllers
    {
        AlunoModel aluno = new AlunoModel();

        public void CadastraAluno() {            
            string resposta = "";            
            try
            {
                Console.WriteLine("Cadastro de Aluno\r\n");

                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite o curso do aluno: ");
                aluno.Curso = Console.ReadLine();
                Console.WriteLine("Digite a idade do aluno: ");
                aluno.Idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o RG do aluno: ");
                aluno.RG = Console.ReadLine();
                
                Console.WriteLine("O aluno é bolsista? S/N");
                resposta = Console.ReadLine();

                if(resposta.ToLower() == "s") {
                    aluno.Bolsista = true;
                } else {
                    aluno.Bolsista = false;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Erro na entrada de dados :(");
            }
        }

        public void MostraAluno() {
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Curso: {aluno.Curso}");
            Console.WriteLine($"Idade: {aluno.Idade}");
            Console.WriteLine($"RG: {aluno.RG}");
            Console.WriteLine($"Aluno Bolsista: {aluno.Bolsista}");
        }
    }
}