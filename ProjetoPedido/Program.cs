using ProjetoPedido.Entities;
using ProjetoPedido.Entities.Enums;
using System;
using System.Globalization;


namespace ProjetoPedid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------Entre com os dados do cliente:-------------------------------------");
            Console.Write("Nome: ");
            string clienteNome = Console.ReadLine();
            Console.Write("Entre com o e-mail: ");
            string email = Console.ReadLine();
            Console.Write("Entre com a data de aniversário: (DD/MM/YYYY): ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("------------------------------------Entre com os dados do pedido:--------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Status: Pagamento_Pendente = 0, Processando = 1, Enviado = 2, Entregue = 3 ");
            Console.WriteLine();
            Console.Write("Status do pedido: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(clienteNome, email, dataAniversario);
            Pedido pedido = new Pedido(DateTime.Now, status, cliente);

            Console.WriteLine("---------------------------------Quantos produtos haverá no pedido?------------------------------------");
            Console.Write("Digite a quantidade: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Entre com o #{i}º item do pedido:");
                Console.Write("Descrição do prduto: ");
                string produtoNome = Console.ReadLine();
                Console.Write("Entre com preço do produto: ");
                double produtoPreco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(produtoNome, produtoPreco);

                Console.Write("Entre com a quantidade do produto: ");
                int produtoQuantidade = int.Parse(Console.ReadLine());

                ProdutoPedido produtoPedido = new ProdutoPedido(produtoQuantidade, produtoPreco, produto);

                pedido.AddProduto(produtoPedido);              

            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------Dados do Pedido:-------------------------------------------------");
            Console.WriteLine(pedido);
        }
    }
}