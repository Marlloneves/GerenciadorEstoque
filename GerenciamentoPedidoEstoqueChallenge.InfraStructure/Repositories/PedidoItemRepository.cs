using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories
{
    public class PedidoItemRepository : BaseRepository<PedidoItem>, IPedidoItemRepository
    {
        public PedidoItemRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
