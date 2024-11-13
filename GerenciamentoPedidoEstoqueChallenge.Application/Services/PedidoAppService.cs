using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Services
{
    public class PedidoAppService : IBaseAppService<PedidoRequestDto, PedidoResponseDto>, IPedidoAppService
    {
        private readonly IPedidoDomainService _pedidoDomainService;
        private readonly IMapper _mapper;

        public PedidoAppService(IPedidoDomainService pedidoDomainService, IMapper mapper)
        {
            _pedidoDomainService = pedidoDomainService;
            _mapper = mapper;
        }

        public PedidoResponseDto Atualizar(int id, PedidoRequestDto entity)
        {
            var pedido = _pedidoDomainService.Obter(id);
            if (pedido is null) return null;
            pedido.AlterarDados(entity.PedidoData, entity.Status, entity.ClienteId);
            return _mapper.Map<PedidoResponseDto>(pedido);
        }

        public PedidoResponseDto Excluir(int id)
        {
            var pedido = _pedidoDomainService.Obter(id);
            if (pedido is null) return null;
            _pedidoDomainService.Excluir(pedido);
            return _mapper.Map<PedidoResponseDto>(pedido);
        }

        public PedidoResponseDto Inserir(PedidoRequestDto entity)
        {
            var pedido = _mapper.Map<Pedido>(entity);

            _pedidoDomainService.Inserir(pedido);

            return _mapper.Map<PedidoResponseDto>(pedido);
        }

        public List<PedidoResponseDto> Listar()
        {
            return _mapper.Map<List<PedidoResponseDto>>(_pedidoDomainService.Listar());
        }

        public PedidoResponseDto? Obter(int id)
        {
            var pedido = _pedidoDomainService.Obter(id);
            if(pedido is null) return null;
            return _mapper.Map<PedidoResponseDto>(pedido);
        }
    }
}
