using exercicioVingadores.Models;

namespace exercicioVingadores.Controllers
{
    public class CapitaoControllers : HeroiControllers
    {
        CapitaoModel capitao = new CapitaoModel();

        public void Lancar(){
            System.Console.WriteLine("Lançou o Escudo");
        }
        public void Defender(){
            System.Console.WriteLine("Defender com Escudo");
        }
    }
}