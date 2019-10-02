using System;
using exercicioVingadores.Controllers;

namespace exercicioVingadores
{
    class Program
    {
        static void Main(string[] args)
        {

            string resposta;

            HeroiControllers CapitaoAmerica = new HeroiControllers();

            HeroiControllers HomemDeFerro = new HeroiControllers();

            // HeroiControllers heroi = new HeroiControllers();

            HomemDeFerro.MostrarInformacoes();

            System.Console.WriteLine("Qual Personagem deseja Jogar?");

            resposta = Console.ReadLine();

            if(resposta == "Capitao"){

                CapitaoControllers heroi = new CapitaoControllers();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;

                System.Console.WriteLine("Qual comando deseja fazer?");
                System.Console.WriteLine("Pular");

                System.Console.WriteLine("Lançar");

                System.Console.WriteLine("Defender");

               resposta = Console.ReadLine();

                if(resposta == "Pular"){
                    heroi.Pular();
                }

                if(resposta == "Lançar"){
                    heroi.Lancar();
                }
                if(resposta == "Defender"){
                    heroi.Defender();
                }

            }else if(resposta == "HomemDeFerro")
            {
                HomemControllers heroi = new HomemControllers();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;

                System.Console.WriteLine("Qual comando deseja fazer?");
                System.Console.WriteLine("Pular");

                System.Console.WriteLine("Voar");

                System.Console.WriteLine("Atirar");

                resposta = Console.ReadLine();

                if(resposta == "Pular")
                {
                    heroi.Pular();
                }

                if(resposta == "Voar")
                {
                    heroi.Voar();
                }

                if(resposta == "Atirar")
                {
                    heroi.Atirar();
                }

            }else
            {
                System.Console.WriteLine("entrada invalida");
            }  

                Console.ResetColor();
            
        }
    }
}
