using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Services
{
    public class PedidoDomainService : BaseDomainService<Pedido>, IPedidoDomainService
    {
        public PedidoDomainService(IUnitOfWork<Pedido> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
