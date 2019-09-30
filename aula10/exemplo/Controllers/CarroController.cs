using System;
using exemplo.Models;

namespace exemplo.Controllers
{
    public class CarroController
    {
        CarroModel carro = new CarroModel();
        MotorModel motor = new MotorModel();

        public void Ligar() {
            carro.Ligado = true;
            Console.WriteLine("Ligando Carro!");
        }

        public void Desligar() {
            carro.Ligado = false;
            Console.WriteLine("Desligando Carro!");
        }

        public void Acelerar() {
            if(carro.Ligado == true) {
                Console.WriteLine("Carro acelerando");
            } else {
                Console.WriteLine("Carro Desligado, impossível acelerar!");
            }
        }

        public void Frear() {
            if(carro.Ligado == true) {
                Console.WriteLine("Carro Freando...");
            } else {
                Console.WriteLine("Carro Desligado, impossível frear...");
            }
        }

        public void CadastrarMotor() {
            Console.WriteLine("Digite quantos cavalos tem o motor: ");
            motor.Cavalos = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite quantos cilindros tem o motor: ");
            motor.Cilindros = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o modelo do pistão do motor: ");
            motor.Pistao = Console.ReadLine();
        }
    }
}