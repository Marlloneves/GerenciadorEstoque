using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Services
{
    public class ProdutoDomainService : BaseDomainService<Produto>, IProdutoDomainService
    {
        public ProdutoDomainService(IUnitOfWork<Produto> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
