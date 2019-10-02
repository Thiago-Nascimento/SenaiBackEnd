using System;
using System.Collections.Generic;
using exercicioClasseNV2.Controllers;

namespace exercicioClasseNV2
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoControllers aluno1 = new AlunoControllers();
            AlunoControllers alunoConstrutor = new AlunoControllers("thiago", "CodeXP", 21, "34876592-8", true);
            CelularControllers celular1 = new CelularControllers();
            ProdutoControllers produto1 = new ProdutoControllers();
            CalculadoraControllers calculadora1 = new CalculadoraControllers();
            CalculadoraCientificaControllers calculadora2 = new CalculadoraCientificaControllers();
            PedidoControllers pedido1 = new PedidoControllers();
                
            #region Aluno
                aluno1.CadastraAluno();
                Console.WriteLine();
                aluno1.MostraAluno();
                Console.WriteLine();
            #endregion

            #region AlunoConstrutor
                Console.WriteLine("Aluno Construtor...");
                alunoConstrutor.MostraAluno();
            #endregion

            Console.WriteLine("\r\n__________________________________________\r\n");

            #region Celular                
                celular1.FazerLigacao();
                Console.WriteLine();
                celular1.EnviarMensagem();
                Console.WriteLine();
                celular1.Ligar();
                celular1.FazerLigacao();
                Console.WriteLine();
                celular1.EnviarMensagem();
                Console.WriteLine();
                celular1.Desligar();
                celular1.FazerLigacao();
                Console.WriteLine();
                celular1.EnviarMensagem();
            #endregion

            Console.WriteLine("\r\n__________________________________________\r\n");
            
            #region Produto                
                produto1.CadastraProduto();
                produto1.ReservarProduto();       
                produto1.ReservarProduto();  
            #endregion

            #region ProdutoLista
                
            #endregion

            Console.WriteLine("\r\n__________________________________________\r\n");

            #region Calculadora                
                calculadora1.DigitarNumeros();
                
                calculadora1.Somar();   
                calculadora1.Subtrair();
                calculadora1.Multiplicar();
                calculadora1.Dividir();

                calculadora2.DigitarNumeros();
                calculadora2.Potencia();
                calculadora2.Somar();
            #endregion

            Console.WriteLine("\r\n__________________________________________\r\n");

            #region Pizzaria
                pedido1.LerPedido();
            #endregion
        }
    }
}
