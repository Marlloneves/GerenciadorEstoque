namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests
{
    public class PedidoRequestDto
    {
        public int ClienteId { get; set; }
        public DateTime PedidoData { get; set; }
        public string Status { get; set; }
        public List<PedidoItemRequestDto> PedidoItem { get; set; }
    }
}
