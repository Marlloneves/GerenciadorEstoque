namespace GerenciamentoPedidoEstoqueChallenge.Domain.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public ICollection<Produto> Produtos { get; set; }

        public void AlterarDados(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }
    }
}
