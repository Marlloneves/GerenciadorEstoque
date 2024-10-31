using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;
using Microsoft.EntityFrameworkCore.Storage;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories
{
    public class UnitOfWork<TEntity> : IUnitOfWork<TEntity>
        where TEntity : class
    {
        private readonly DataContext _dataContext;
        private IDbContextTransaction _transaction;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IBaseRepository<TEntity> BaseRepository => new BaseRepository<TEntity>(_dataContext);

        public IClienteRepository ClienteRepository => new ClienteRepository(_dataContext);

        public IFornecedorRepository FornecedorRepository => new FornecedorRepository(_dataContext);

        public IPedidoItemRepository PedidoItemRepository => new PedidoItemRepository(_dataContext);

        public IProdutoRepository ProdutoRepository => new ProdutoRepository(_dataContext);

        public IUsuarioRepository UsuarioRepository => new UsuarioRepository(_dataContext);

        public void BeginTransaction()
        {
            _transaction = _dataContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction!.Commit();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public void Rollback()
        {
            _transaction!.Rollback();
        }
    }
}
