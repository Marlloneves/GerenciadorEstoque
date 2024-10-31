using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Services
{
    public class PedidoItemAppService : IBaseAppService<PedidoItemRequestDto, PedidoItemResponseDto>, IPedidoItemAppService
    {
        private readonly IPedidoItemDomainService _pedidoItemDomainService;
        private readonly IMapper _mapper;

        public PedidoItemAppService(IPedidoItemDomainService pedidoItemDomainService, IMapper mapper)
        {
            _pedidoItemDomainService = pedidoItemDomainService;
            _mapper = mapper;
        }

        public PedidoItemResponseDto Atualizar(int id, PedidoItemRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public PedidoItemResponseDto Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public PedidoItemResponseDto Inserir(PedidoItemRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public List<PedidoItemResponseDto> Listar()
        {
            throw new NotImplementedException();
        }

        public PedidoItemResponseDto? Obter(int id)
        {
            throw new NotImplementedException();
        }
    }
}
