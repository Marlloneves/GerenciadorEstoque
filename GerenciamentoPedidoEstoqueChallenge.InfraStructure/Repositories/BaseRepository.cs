using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {
        private readonly DataContext _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public virtual void Atualizar(TEntity entity)
        {
            _dataContext?.Update(entity);
            _dataContext?.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }

        public virtual void Excluir(TEntity entity)
        {
            _dataContext?.Remove(entity);
            _dataContext?.SaveChanges();
        }

        public void Inserir(TEntity entity)
        {
            _dataContext?.Add(entity);
            _dataContext?.SaveChanges();
        }

        public List<TEntity> Listar()
        {
            return _dataContext?.Set<TEntity>()
                .AsNoTracking()
                .ToList();
        }

        public List<TEntity> Listar(Func<TEntity, bool> where)
        {
            return _dataContext?.Set<TEntity>()
                .AsNoTracking()
                .Where(where)
                .ToList();
        }

        public TEntity? Obter(int id)
        {
            return _dataContext?.Set<TEntity>().Find(id);
        }

        public TEntity? Obter(Func<TEntity, bool> where)
        {
            return _dataContext?.Set<TEntity>().AsNoTracking().FirstOrDefault(where);
        }
    }
}
