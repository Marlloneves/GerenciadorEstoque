using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IBaseRepository<Produto>
    {
        void DiminuirQuantidadeProdutoEstoquePedidoRealizado(int produtoId, int quantidadeItensProduto);
        void ReporQuantidadeProdutoEstoquePedidoCancelado(int produtoId, int quantidadeItensProduto);

    }
}
