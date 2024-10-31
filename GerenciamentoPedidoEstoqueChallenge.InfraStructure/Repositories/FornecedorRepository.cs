using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
