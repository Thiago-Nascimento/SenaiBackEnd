using System;
using exemplo.Models;

namespace exemplo.Controllers
{
    public class CarroEletricoController : CarroController
    {
        CarroEletricoModel carroEletrico = new CarroEletricoModel();
        MotorModel motor = new MotorModel();

        public void CarregarBateria(float carga) {
            if(carroEletrico.Bateria < 100) {
                carroEletrico.Bateria += carga;
            } else {
                Console.WriteLine("A bateria já está carregada");
            }
        }

        public float StatusBateria() {
            return carroEletrico.Bateria;
        }
    }
}