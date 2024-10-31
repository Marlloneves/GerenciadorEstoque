namespace GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork<TEntity> : IDisposable where TEntity : class
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        IBaseRepository<TEntity> BaseRepository { get; }
        IClienteRepository ClienteRepository { get; }
        IFornecedorRepository FornecedorRepository { get; }
        IPedidoItemRepository PedidoItemRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
    }
}
