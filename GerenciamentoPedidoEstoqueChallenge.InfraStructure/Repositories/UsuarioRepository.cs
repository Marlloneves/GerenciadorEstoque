using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
