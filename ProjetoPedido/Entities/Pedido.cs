using System;
using ProjetoPedido.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjetoPedido.Entities
{
    class Pedido
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public  Cliente Cliente{ get; set; }
        public List<ProdutoPedido> Produtos { get; set; } = new List<ProdutoPedido>();

        public Pedido()
        {

        }

        public Pedido(DateTime moment, OrderStatus status, Cliente cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddProduto(ProdutoPedido produto)
        {
            Produtos.Add(produto);
        }

        public void RemoveProduto(ProdutoPedido produto)
        {
            Produtos.Remove(produto);
        }


        public double Total()
        {
            double soma = 0.0;
            foreach (ProdutoPedido produto in Produtos)
            {
                soma += produto.SubTotal(); 
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Data do pedido: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do Pedido: "+ Status);
            sb.AppendLine("Cliente: " + Cliente);
            sb.AppendLine("Itens do pedido: ");
            foreach(ProdutoPedido produto in Produtos)
            {
                sb.AppendLine(produto.ToString());
            }
            sb.AppendLine("Preço total: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
