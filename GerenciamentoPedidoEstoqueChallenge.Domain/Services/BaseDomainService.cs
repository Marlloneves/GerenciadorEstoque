using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Services
{
    public class BaseDomainService<TEntity> : IBaseDomainService<TEntity>
        where TEntity : class
    {
        private readonly IUnitOfWork<TEntity> _unitOfWork;

        public BaseDomainService(IUnitOfWork<TEntity> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Atualizar(TEntity entity)
        {
            _unitOfWork.BaseRepository.Atualizar(entity);
        }

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }

        public void Excluir(TEntity entity)
        {
            _unitOfWork.BaseRepository?.Excluir(entity);
        }

        public void Inserir(TEntity entity)
        {
            _unitOfWork.BaseRepository.Inserir(entity);
        }

        public List<TEntity> Listar()
        {
            return _unitOfWork.BaseRepository.Listar();
        }

        public List<TEntity> Listar(Func<TEntity, bool> where)
        {
            return _unitOfWork.BaseRepository.Listar(where);
        }

        public TEntity? Obter(int id)
        {
            return _unitOfWork.BaseRepository.Obter(id);
        }

        public TEntity? Obter(Func<TEntity, bool> where)
        {
            return _unitOfWork.BaseRepository.Obter(where);
        }
    }
}
