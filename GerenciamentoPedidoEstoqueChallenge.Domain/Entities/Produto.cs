namespace GerenciamentoPedidoEstoqueChallenge.Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int MinimoStoque { get; set; }
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public ICollection<PedidoItem> PedidoItens { get; set; }
    }
}
