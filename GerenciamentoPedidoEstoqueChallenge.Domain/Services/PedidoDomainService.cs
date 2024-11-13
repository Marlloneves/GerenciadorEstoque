using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Services
{
    public class PedidoDomainService : BaseDomainService<Pedido>, IPedidoDomainService
    {
        private readonly IUnitOfWork<Pedido> _unitOfWork;
        public PedidoDomainService(IUnitOfWork<Pedido> unitOfWork) : base(unitOfWork)
        {
        }

        public override void Inserir(Pedido entity)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                foreach (var item in entity.PedidoItens)
                {
                    var produto = _unitOfWork.ProdutoRepository.Obter(item.ProdutoId);

                    if (produto is null)
                        throw new InvalidOperationException($"Produto {item.ProdutoId} não encontrado.");

                    if (!VerificarEstoqueDisponivel(entity))
                        throw new InvalidOperationException($"Estoque insuficiente do produto {item.ProdutoId} para a realização do pedido.");

                    _unitOfWork.ProdutoRepository.DiminuirQuantidadeProdutoEstoquePedidoRealizado(produto.Id, item.Quantidade);
                }

                _unitOfWork.PedidoRepository.Inserir(entity);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public override void Excluir(Pedido entity)
        {
            try
            {
                _unitOfWork.BeginTransaction();

                foreach (var item in entity.PedidoItens)
                {
                    var produto = _unitOfWork.ProdutoRepository.Obter(item.ProdutoId);

                    if (produto is null) throw new InvalidOperationException($"Produto {item.ProdutoId} não encontrado.");

                    _unitOfWork.ProdutoRepository.ReporQuantidadeProdutoEstoquePedidoCancelado(item.ProdutoId, item.Quantidade);
                }
                _unitOfWork.PedidoRepository.Excluir(entity);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.Rollback();
                throw;
            }
        }

        public bool VerificarEstoqueDisponivel(Pedido pedido)
        {
            foreach (var item in pedido.PedidoItens)
            {
                var produto = _unitOfWork.ProdutoRepository.Obter(item.ProdutoId);
                if(produto is null || produto.QuantidadeEstoque < item.Quantidade)
                    return false;
            }
            return true;
        }
    }
}
