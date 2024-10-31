using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Services
{
    public class FornecedorDomainService : BaseDomainService<Fornecedor>, IFornecedorDomainService
    {
        public FornecedorDomainService(IUnitOfWork<Fornecedor> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
