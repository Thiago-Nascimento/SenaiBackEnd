using System;

namespace exemploCpf
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf;            

            Console.WriteLine("Exercício CPF\n");

            Console.WriteLine("Insira o CPF para Teste: ");
            cpf = Console.ReadLine();

            Console.WriteLine(ValidaCpf(cpf));
        }

        static bool ValidaCpf(string cpfUsuario) {
            bool resultado = false;
            int[] v1 = {10, 9, 8, 7, 6, 5, 4, 3, 2};
            
            string cpfCalculo = "";
            string digitoVerificador1 = "";
            string digitoVerificador2 = "";

            int[] v2 = {11, 10, 9, 8, 7, 6, 5, 4, 3, 2};
            
            int calculo = 0;
            int resto = 0;

            // cpfUsuario = cpfUsuario.Trim('.');
            // cpfUsuario = cpfUsuario.Trim('-');

            cpfCalculo = cpfUsuario.Substring(0, 9);

            for(int i = 0; i <= 8; i++) {
                calculo = calculo + (int.Parse(cpfCalculo[i].ToString()) * v1[i]);
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(calculo > 9) {
                digitoVerificador1 = "0";
            } else {
                digitoVerificador1 = calculo.ToString();
            }

            if(digitoVerificador1 == cpfUsuario[9].ToString()) {
                resultado = true;
            }

            cpfCalculo = cpfCalculo + calculo.ToString();
            
            resto = 0;
            calculo = 0;

            for(int i = 0; i <= 9; i++) {
                calculo = calculo + (int.Parse(cpfCalculo[i].ToString()) * v2[i]);
            }

            resto = calculo % 11;
            calculo = 11 - resto;

            if(calculo > 9) {
                digitoVerificador2 = "0";
            } else {
                digitoVerificador2 = calculo.ToString();
            }

            if(digitoVerificador2 == cpfUsuario[10].ToString()) {
                resultado = true;
            } else {
                resultado = false;
            }

            return resultado;
        }
    }
}
