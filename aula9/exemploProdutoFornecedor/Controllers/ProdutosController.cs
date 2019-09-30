using System;
using System.IO;
using exemploProdutoFornecedor.Models;

namespace exemploProdutoFornecedor.Controllers
{
    public class ProdutosController
    {
        ProdutosModel produto = new ProdutosModel();
        
        public void CadastrarProduto() {
            try
            {
                Console.WriteLine("Digite o Id do produto: ");
                produto.IdProduto = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome do produto: ");
                produto.NomeProduto = Console.ReadLine();

                Console.WriteLine("Digite a descricao do produto: ");
                produto.Descricao = Console.ReadLine();

                Console.WriteLine("Digite o preço do produto: ");
                produto.Preco = double.Parse(Console.ReadLine());

                // Console.WriteLine("Digite o id do fornecedor: ");
                // produto.Fornecedor.IdFornecedor = int.Parse(Console.ReadLine());
                
                // Console.WriteLine("Digite o nome do fornecedor: ");
                // produto.Fornecedor.NomeFornecedor = Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Desculpe :( Houve um erro na aplicação.");
                SalvarErros(ex);
            }
        }

        public void ExibirProduto() {
            Console.WriteLine($"Id do produto: {produto.IdProduto}");
            Console.WriteLine($"Nome do produto: {produto.NomeProduto}");
            Console.WriteLine($"Descricao do produto: {produto.Descricao}");
            Console.WriteLine($"Preço do produto: {produto.Preco}");
            // Console.WriteLine($"Id do fornecedor do produto: {produto.Fornecedor.IdFornecedor}");
            // Console.WriteLine($"Nome do fornecedor do produto: {produto.Fornecedor.NomeFornecedor}");
        }

        private void SalvarErros(Exception ex) {
            StreamWriter txt = new StreamWriter("error_log.txt", true);

            txt.WriteLine(DateTime.Now.ToLongDateString());
            txt.WriteLine(DateTime.Now.ToShortTimeString());
            txt.WriteLine(ex);
            txt.WriteLine();

            txt.Close();
        }
    }
}