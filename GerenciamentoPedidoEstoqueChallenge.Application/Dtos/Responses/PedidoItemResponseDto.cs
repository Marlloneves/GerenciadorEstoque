namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses
{
    public class PedidoItemResponseDto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnidade { get; set; }
        public decimal TotalPreco => Quantidade * PrecoUnidade;
    }
}
