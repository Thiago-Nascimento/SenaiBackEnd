using System;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class CalculadoraCientificaControllers : CalculadoraControllers
    {
        CalculadoraCientificaModels calculadora = new CalculadoraCientificaModels();

        public double Potencia() {
            return Math.Pow(calculadora.numero1, calculadora.numero2);
        }
    }
}