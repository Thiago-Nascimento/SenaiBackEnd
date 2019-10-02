namespace exercicioVingadores.Controllers
{
    public class HomemControllers : HeroiControllers
    {
        HomemModel hoemDeFerro = new HomemModel();

        public void Voar(){
            System.Console.WriteLine("Vuou");
        }
        public void Atirar(){
            System.Console.WriteLine("Atirar");
        }
    }
}