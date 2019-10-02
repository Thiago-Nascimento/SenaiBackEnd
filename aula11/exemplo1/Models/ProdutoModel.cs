namespace exemplo1.Models
{
    public class ProdutoModel
    {
        
        public int IdProduto { get; set; }
        public string NomeProduto {get;set;}
        public string  Descricao { get; set; }
        public double Preco { get; set; }
        
        public ProdutoModel(int id, string nome, string descricao, double preco) {
            this.IdProduto = id; 
            this.NomeProduto = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public ProdutoModel(){
            
        }
    }
}