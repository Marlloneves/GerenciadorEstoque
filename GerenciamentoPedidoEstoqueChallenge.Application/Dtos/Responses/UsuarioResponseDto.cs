namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses
{
    public class UsuarioResponseDto
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
