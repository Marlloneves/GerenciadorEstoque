using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Services
{
    public class PedidoItemDomainService : BaseDomainService<PedidoItem>, IPedidoItemDomainService
    {
        public PedidoItemDomainService(IUnitOfWork<PedidoItem> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
