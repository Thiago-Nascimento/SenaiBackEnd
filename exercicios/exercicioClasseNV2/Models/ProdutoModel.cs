namespace exercicioClasseNV2.Models
{
    public class ProdutoModel
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public double Preco {get;set;}
        public bool Reservado {get;set;}

        public ProdutoModel() {

        }

        public ProdutoModel(int id, string nome, double preco) {
            this.Id = id;
            this.Nome = nome;
            this.Preco = preco;
        }
    }
}