using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services
{
    public interface IPedidoDomainService : IBaseDomainService<Pedido>
    {
        bool VerificarEstoqueDisponivel(Pedido pedido);
    }
}
