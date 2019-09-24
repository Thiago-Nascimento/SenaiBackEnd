using System;

namespace aula6
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = {2, 5, 2, 8, 9, 5};
            double[] valores2 = {2, 5, 2, 8, 9, 5};
            
            Console.WriteLine(BomDia("Boa Tarde"));
            ImprimeDataHora();

            Console.WriteLine(CalculaMedia(valores));

            for(int i = 0; i < valores.Length; i++) {
                Console.WriteLine(SomaValores(valores, valores2)[i]);
            }
        }

        /// <summary>
        /// Função que escreve Bom Dia! para o usuário
        /// </summary>
        /// <returns>
        /// Retorna Bom Dia!
        /// </returns>
        static string BomDia() {
            return "Bom Dia!";
        }

        /// <summary>
        /// Função que mostra um saudação de acordo com o horario
        /// </summary>
        /// <param name="saudacao">Qualquer "string" (Para sobrecarga de método)</param>
        /// <returns>Saudação de acordo com o horario</returns>
        static string BomDia(string saudacao) {

            int hora = DateTime.Now.Hour;

            if(hora >= 6 && hora <= 12) {
                return "Bom Dia!";
            } else if (hora > 12 && hora <= 18) {
                return "Boa Tarde";
            } else {
                return "Boa Noite";
            }
        }

        /// <summary>
        /// Função que retorna data e hora atuais
        /// </summary>
        static void ImprimeDataHora() {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.Hour);
        }

        /// <summary>
        /// Função que calcula a média dos valores de um vetor
        /// </summary>
        /// <param name="valores">Vetor com valores double</param>
        /// <returns>Média dos Valores</returns>
        static double CalculaMedia(double[] valores) {
            double result = 0;

            for(int i = 0; i < valores.Length; i++) {
                result = result + valores[i];
            }

            result = result / valores.Length;

            return result;
        }

        /// <summary>
        /// Soma Valores de dois vetores em um terceiro vetor
        /// </summary>
        /// <param name="vetor1"></param>
        /// <param name="vetor2"></param>
        /// <returns>vetor com a soma dos dois inserido</returns>
        static double[] SomaValores(double[] vetor1, double[] vetor2) {
            double[] resultado = new double[vetor1.Length];
            
            for(int i = 0; i < vetor1.Length; i++) {
                resultado[i] = vetor1[i] + vetor2[i];
            }
            
            return resultado;
        }
    }
}
