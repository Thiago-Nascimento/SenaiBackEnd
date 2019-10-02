using System;
using System.Collections.Generic;
using exemplo1.Models;

namespace exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoModel produto1 = new ProdutoModel(2, "Maçã", "Fruta", 1.00);

            ProdutoModel produto2 = new ProdutoModel();
            produto2.IdProduto = 2;
            produto2.NomeProduto = "Carambola";

            List<ProdutoModel> prod = new List<ProdutoModel>();

            prod.Add(new ProdutoModel(1, "Cenoura", "Descricao", 1.20));
            prod.Add(new ProdutoModel(1, "Mamão", "Descricao", 1.20));
            prod.Add(new ProdutoModel(1, "Manga", "Descricao", 1.20));
            prod.Add(new ProdutoModel(1, "Abóbora", "Descricao", 1.20));
            prod.Add(new ProdutoModel(1, "Laranja", "Descricao", 1.20));
            prod.Add(new ProdutoModel(1, "Limão", "Descricao", 1.20));

            foreach (ProdutoModel p in prod)
            {
                Console.WriteLine();
                Console.WriteLine(p.IdProduto);                
                Console.WriteLine(p.NomeProduto);                
                Console.WriteLine(p.Descricao);                
                Console.WriteLine(p.Preco);            
            }

            Console.WriteLine(prod[4].NomeProduto);
        }
    }
}
