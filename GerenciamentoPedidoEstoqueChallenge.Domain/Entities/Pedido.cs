namespace GerenciamentoPedidoEstoqueChallenge.Domain.Entities
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime PedidoData { get; set; }
        public string Status { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public ICollection<PedidoItem> PedidoItens { get; set; }

        public void AlterarDados(DateTime pedidoData, string status, int clienteId)
        {
            PedidoData = pedidoData;
            Status = status;
            ClienteId = clienteId;
        }
    }
}
