using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Services
{
    public class ClienteAppService : IBaseAppService<ClienteRequestDto, ClienteResponseDto>, IClienteAppService
    {
        private readonly IClienteDomainService _clienteDomainService;
        private readonly IMapper _mapper;

        public ClienteAppService(IClienteDomainService clienteDomainService, IMapper mapper)
        {
            _clienteDomainService = clienteDomainService;
            _mapper = mapper;
        }

        public ClienteResponseDto Atualizar(int id, ClienteRequestDto entity)
        {
            var cliente = _clienteDomainService.Obter(id);

            if (cliente is null) return null;

            cliente.AlterarDados(entity.Nome, entity.Email, entity.Telefone);

            return _mapper.Map<ClienteResponseDto>(cliente);
        }

        public ClienteResponseDto Excluir(int id)
        {
            var cliente = _clienteDomainService.Obter(id);

            if (cliente is null) return null;

            _clienteDomainService.Excluir(cliente);

            return _mapper.Map<ClienteResponseDto>(cliente);
        }

        public ClienteResponseDto Inserir(ClienteRequestDto entity)
        {
            var cliente = _mapper.Map<Cliente>(entity);
            _clienteDomainService.Inserir(cliente);
            return _mapper.Map<ClienteResponseDto>(cliente);
        }

        public List<ClienteResponseDto> Listar()
        {
            var clientes = _clienteDomainService.Listar();
            return _mapper.Map<List<ClienteResponseDto>>(clientes);
        }

        public ClienteResponseDto? Obter(int id)
        {
            var cliente = _clienteDomainService.Obter(id);
            if(cliente is null) return null;
            return _mapper.Map<ClienteResponseDto>(cliente);
        }
    }
}
