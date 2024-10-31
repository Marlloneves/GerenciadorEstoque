namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests
{
    public class PedidoItemRequestDto
    {
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnidade { get; set; }
    }
}
