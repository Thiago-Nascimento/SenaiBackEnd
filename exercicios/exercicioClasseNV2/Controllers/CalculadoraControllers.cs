using System;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class CalculadoraControllers
    {
        CalculadoraModel calculadora = new CalculadoraModel();

        public void DigitarNumeros() {
            try
            {
                Console.Write("Digite o primeiro numero: ");
                calculadora.numero1 = double.Parse(Console.ReadLine());
                Console.Write("Digite o segundo numero: ");
                calculadora.numero2 = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Erro na entrada de dados :)");
            }                        
        }
        
        public double Somar() {
            return calculadora.numero1 + calculadora.numero2;
        }

        public double Subtrair() {
            return calculadora.numero1 - calculadora.numero2;
        }

        public double Multiplicar() {
            return calculadora.numero1 * calculadora.numero2;
        }

        public double Dividir() {
            return calculadora.numero1 / calculadora.numero2;
        }
    }
}