namespace GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        void Inserir(TEntity entity);
        void Atualizar(TEntity entity);
        void Excluir(TEntity entity);
        List<TEntity> Listar();
        List<TEntity> Listar(Func<TEntity, bool> where);
        TEntity? Obter(int id);
        TEntity? Obter(Func<TEntity, bool> where);
    }
}
