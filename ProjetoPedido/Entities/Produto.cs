namespace ProjetoPedido.Entities
{
    class Produto
    {
        public string NomeProduto { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nomeProduto, double preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }
    }
}
