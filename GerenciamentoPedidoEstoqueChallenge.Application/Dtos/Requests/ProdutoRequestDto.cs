namespace GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests
{
    public class ProdutoRequestDto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int QuanditadeEstoque { get; set; }
        public int MinimoStoque { get; set; }
        public int FornecedorId { get; set; }
    }
}
