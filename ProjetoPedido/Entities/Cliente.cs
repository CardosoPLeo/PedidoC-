using System;

namespace ProjetoPedido.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataAniversario { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string email, DateTime data_Aniversario)
        {
            Nome = nome;
            Email = email;
            DataAniversario = data_Aniversario;
        }

        public override string ToString()
        {
            return Nome
                + ", ("
                + DataAniversario.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
