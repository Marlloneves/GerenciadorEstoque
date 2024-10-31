using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Interfaces
{
    public interface IFornecedorAppService : IBaseAppService<FornecedorRequestDto,FornecedorResponseDto>
    {
    }
}
