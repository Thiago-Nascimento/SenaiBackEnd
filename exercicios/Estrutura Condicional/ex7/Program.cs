using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa, finalPlaca, resultado;
            int caracteres;

            Console.Write("Digite a placa do seu carro: ");
            placa = Console.ReadLine();

            caracteres = placa.Length;

            // Pegamos o ultimo char com o método Substring
            finalPlaca = placa.Substring(caracteres - 1);

            if(finalPlaca == "1" || finalPlaca == "2") {
                resultado = "Seu rodízio é na Segunda-Feira";
            } else if (finalPlaca == "3" || finalPlaca == "4") {
                resultado = "Seu rodízio é na Terça-Feira";
            } else if (finalPlaca == "5" || finalPlaca == "6") {
                resultado = "Seu rodízio é na Quarta-Feira";
            } else if (finalPlaca == "7" || finalPlaca == "8") {
                resultado = "Seu rodízio é na Quinta-Feira";
            } else if (finalPlaca == "9" || finalPlaca == "0") {
                resultado = "Seu rodízio é na Sexta-Feira";
            } else {
                resultado = "Placa Inválida";
            }
            
            Console.WriteLine(resultado);

            switch(finalPlaca) {
                case "1":
                resultado = "Switch - Seu rodízio é na Segunda-Feira";
                break;

                case "2":
                resultado = "Switch - Seu rodízio é na Segunda-Feira";
                break;

                case "3":
                resultado = "Switch - Seu rodízio é na Terça-Feira";
                break;

                case "4":
                resultado = "Switch - Seu rodízio é na Terça-Feira";
                break;

                case "5":
                resultado = "Switch - Seu rodízio é na Quarta-Feira";
                break;

                case "6":
                resultado = "Switch - Seu rodízio é na Quarta-Feira";
                break;

                case "7":
                resultado = "Switch - Seu rodízio é na Quinta-Feira";
                break;

                case "8":
                resultado = "Switch - Seu rodízio é na Quinta-Feira";
                break;

                case "9":
                resultado = "Switch - Seu rodízio é na Sexta-Feira";
                break;

                case "0":
                resultado = "Switch - Seu rodízio é na Sexta-Feira";
                break;

                default:
                resultado = "Switch - Placa Inválida";
                break;              
            }
            Console.WriteLine(resultado);
        }
    }
}
