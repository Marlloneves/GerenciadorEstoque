namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses
{
    public class ProdutoResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int MinimoStoque { get; set; }
        public string NomeFornecedor { get; set; }
    }
}
