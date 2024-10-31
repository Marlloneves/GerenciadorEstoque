using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Services
{
    public class UsuarioAppService : IBaseAppService<UsuarioRequestDto, UsuarioResponseDto>, IUsuarioAppService
    {
        private readonly IUsuarioDomainService _usuarioDomainService;
        private readonly IMapper _mapper;

        public UsuarioAppService(IUsuarioDomainService usuarioDomainService, IMapper mapper)
        {
            _usuarioDomainService = usuarioDomainService;
            _mapper = mapper;
        }

        public UsuarioResponseDto Atualizar(int id, UsuarioRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public UsuarioResponseDto Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public UsuarioResponseDto Inserir(UsuarioRequestDto entity)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioResponseDto> Listar()
        {
            throw new NotImplementedException();
        }

        public UsuarioResponseDto? Obter(int id)
        {
            throw new NotImplementedException();
        }
    }
}
