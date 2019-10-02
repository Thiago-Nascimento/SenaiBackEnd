using System;
using exercicioClasseNV2.Models;

namespace exercicioClasseNV2.Controllers
{
    public class PedidoControllers
    {
        PedidoModel pedido = new PedidoModel();
        PizzaModel pizza = new PizzaModel();
        
        public void LerPedido() {
            Console.WriteLine("Digite o pedido.\n");

            Console.WriteLine("Tipo de Pizza: Doce/Salgada");
            pizza.Tipo = Console.ReadLine();

            Console.WriteLine("Nome da Pizza: ");
            pizza.Nome = Console.ReadLine();

            Console.WriteLine("Preço da Pizza: ");
            pizza.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine("Tamanho da Pizza: Grande ou Média");
            pizza.Tamanho = Console.ReadLine();

            Console.WriteLine("Endereço de Entrega: ");
            pedido.EnderecoEntrega = Console.ReadLine();

            Console.WriteLine("\nPedido Concluído");
            pedido.DataPedido = DateTime.Now;
            Console.WriteLine($"Data e hora do Pedido: {pedido.DataPedido.ToString("MM/dd/yyyy HH:mm")}");
            pedido.PrevisaoEntrega = DateTime.Now.AddMinutes(30);
            Console.WriteLine($"Previsão de Entrega: {pedido.PrevisaoEntrega.ToString("MM/dd/yyyy HH:mm")}\n");
        }
    }
}