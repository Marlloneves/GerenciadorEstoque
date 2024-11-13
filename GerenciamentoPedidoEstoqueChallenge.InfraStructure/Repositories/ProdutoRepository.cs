using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories;
using GerenciamentoPedidoEstoqueChallenge.InfraStructure.Contexts;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly DataContext _dataContext;

        public ProdutoRepository(DataContext dataContext)
            : base(dataContext) 
        {
            _dataContext = dataContext;
        }

        public void DiminuirQuantidadeProdutoEstoquePedidoRealizado(int produtoId, int quantidadeItensProduto)
        {
            var produto = _dataContext.Produto.FirstOrDefault(p => p.Id == produtoId);

            produto.QuantidadeEstoque -= quantidadeItensProduto;
            _dataContext.SaveChanges();
        }

        public void ReporQuantidadeProdutoEstoquePedidoCancelado(int produtoId, int quantidadeItensProduto)
        {
            var produto = _dataContext.Produto.FirstOrDefault(p => p.Id == produtoId);
            produto.QuantidadeEstoque += quantidadeItensProduto;
            _dataContext.SaveChanges();
        }
    }
}
