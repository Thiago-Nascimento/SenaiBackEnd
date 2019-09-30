using exemploPoo.Controllers;

namespace exemploPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoController aluno1 = new AlunoController();

            aluno1.CadastrarAluno();
            aluno1.ExibirAluno();
        }
    }
}
