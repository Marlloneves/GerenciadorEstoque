using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Services
{
    public class ProdutoAppService : IBaseAppService<ProdutoRequestDto, ProdutoResponseDto>, IProdutoAppService
    {
        private readonly IProdutoDomainService _produtoDomainService;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoDomainService produtoDomainService, IMapper mapper)
        {
            _produtoDomainService = produtoDomainService;
            _mapper = mapper;
        }

        public ProdutoResponseDto Atualizar(int id, ProdutoRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public ProdutoResponseDto Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutoResponseDto Inserir(ProdutoRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoResponseDto> Listar()
        {
            throw new NotImplementedException();
        }

        public ProdutoResponseDto? Obter(int id)
        {
            throw new NotImplementedException();
        }
    }
}
