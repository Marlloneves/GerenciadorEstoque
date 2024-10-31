namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses
{
    public class PedidoResponseDto
    {
        public int Id { get; set; }
        public DateTime PedidoData { get; set; }
        public string Status { get; set; }
        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public List<PedidoItemResponseDto> PedidoItens { get; set; }
        public decimal Total { get; set; }
    }
}
