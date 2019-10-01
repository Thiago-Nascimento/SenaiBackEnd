using System;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class CelularControllers
    {
        CelularModel celular = new CelularModel();

        public void Ligar() {
            if(celular.Ligado == true) {
                Console.WriteLine("O celular já está ligado!");
            } else {
                celular.Ligado = true;
                Console.WriteLine("Celular Ligado...");
            }
        }

        public void Desligar() {
            if(celular.Ligado == false) {
                Console.WriteLine("O celular já está desligado!");
            } else {
                celular.Ligado = false;
                Console.WriteLine("Celular Desligado...");
            }
        }

        public void FazerLigacao() {
            if(celular.Ligado == true) {
                Console.WriteLine("Fazendo ligação...");
                Console.Beep();
                Console.WriteLine("Ligação Feita");
            } else {
                Console.WriteLine("Impossível fazer ligação com o celular desligado");                
            }
        }

        public void EnviarMensagem() {
            if(celular.Ligado == true) {
                Console.WriteLine("Enviando Mensagem...");
                Console.Beep();
                Console.WriteLine("Ligação Feita");
            } else {
                Console.WriteLine("Impossível fazer ligação com o celular desligado");                
            }
        }
    }
}