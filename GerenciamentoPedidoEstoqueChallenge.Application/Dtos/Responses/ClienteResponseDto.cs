namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses
{
    public class ClienteResponseDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int TotalPedidos { get; set; } 
        public decimal TotalCompras { get; set; }
    }
}
