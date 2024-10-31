﻿namespace GerenciamentoPedidoEstoqueChallenge.Domain.Entities
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }

        public void AlterarDados(string nome, string email, string telefone)
        {
           Nome = nome;
           Email = email;
           Telefone = telefone;
        }
    }
}
