using System;
using System.Collections.Generic;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class ProdutoControllers
    {
        ProdutoModel produto = new ProdutoModel();       

        public void CadastraProdutos() {
            int id;
            string nome;
            double preco;

            Console.WriteLine("Cadastro de Produto\n");

            List<ProdutoModel> produtos = new List<ProdutoModel>();

            Console.WriteLine("Digite o Id do produto: ");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome do produto: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o Preço do produto: ");
            preco = double.Parse(Console.ReadLine());            

            produtos.Add(new ProdutoModel(1, "Bolacha", 1.25));
            produtos.Add(new ProdutoModel(2, "Biscoito", 1.25));
            produtos.Add(new ProdutoModel(3, "Galleta", 1.25));
            produtos.Add(new ProdutoModel(4, "Biscuit", 1.25));
            produtos.Add(new ProdutoModel(5, "Biscotto", 1.25));

            foreach (ProdutoModel p in produtos)
            {
                Console.WriteLine(p.Id);
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Preco);
            }
        }
        
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