using System;

namespace exercicioClasseNV2.Models
{
    public class PedidoModel
    {
        public DateTime DataPedido {get;set;}
        public PizzaModel Pizza { get; set; }
        public string EnderecoEntrega { get; set; }
        public DateTime PrevisaoEntrega { get; set; }
    }
}