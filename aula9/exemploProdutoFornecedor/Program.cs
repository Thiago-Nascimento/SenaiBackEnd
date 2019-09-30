using System;
using exemploProdutoFornecedor.Controllers;

namespace exemploProdutoFornecedor
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutosController produto1 = new ProdutosController();

            produto1.CadastrarProduto();
            produto1.ExibirProduto();
        }
    }
}
