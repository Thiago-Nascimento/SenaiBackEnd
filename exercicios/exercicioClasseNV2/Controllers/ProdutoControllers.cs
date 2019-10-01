using System;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class ProdutoControllers
    {
        ProdutoModel produto = new ProdutoModel();
        
        public void CadastraProduto() {
            try {
                Console.WriteLine("Cadastro de Produto\r\n");

                Console.WriteLine("Digite o Id do produto: ");
                produto.Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Nome do produto: ");
                produto.Nome = Console.ReadLine();
                Console.WriteLine("Digite o Preço do produto: ");
                produto.Preco = double.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Erro na entrada de dados :(");
            }
        }

        public void ReservarProduto() {
            if(produto.Reservado == false) {
                produto.Reservado = true;
                Console.WriteLine("Produto reservado com sucesso.");
            } else {
                Console.WriteLine("O produto já foi reservado.");
            }
        }
    }
}