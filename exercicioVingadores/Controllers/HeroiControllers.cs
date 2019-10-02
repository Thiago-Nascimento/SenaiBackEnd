using exercicioVingadores.Models;

namespace exercicioVingadores.Controllers
{
    public class HeroiControllers
    {
        HeroiModel heroi = new HeroiModel();

        public void MostrarInformacoes(){
            System.Console.WriteLine(heroi.Vida);
            System.Console.WriteLine(heroi.Cor);
            System.Console.WriteLine(heroi.Equipe);
        }

        public void Pular(){
            System.Console.WriteLine("Pulou");
        }
    }
}