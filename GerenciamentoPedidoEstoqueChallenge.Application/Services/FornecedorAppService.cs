using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using GerenciamentoPedidoEstoqueChallenge.Domain.Interfaces.Services;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Services
{
    public class FornecedorAppService : IBaseAppService<FornecedorRequestDto, FornecedorResponseDto>, IFornecedorAppService
    {
        private readonly IFornecedorDomainService _fornecedorDomainService;
        private readonly IMapper _mapper;

        public FornecedorAppService(IFornecedorDomainService fornecedorDomainService, IMapper mapper)
        {
            _fornecedorDomainService = fornecedorDomainService;
            _mapper = mapper;
        }

        public FornecedorResponseDto Atualizar(int id, FornecedorRequestDto entity)
        {
            var fornecedor = _fornecedorDomainService.Obter(id);
            if (fornecedor is null) return null;
            fornecedor.AlterarDados(entity.Nome, entity.Telefone);
            return _mapper.Map<FornecedorResponseDto>(fornecedor);
        }

        public FornecedorResponseDto Excluir(int id)
        {
            var fornecedor = _fornecedorDomainService.Obter(id);
            if (fornecedor is null) return null;
            _fornecedorDomainService.Excluir(fornecedor);
            return _mapper.Map<FornecedorResponseDto>(fornecedor);
        }

        public FornecedorResponseDto Inserir(FornecedorRequestDto entity)
        {
            var fornecedor = _mapper.Map<Fornecedor>(entity);
            _fornecedorDomainService.Inserir(fornecedor);
            return _mapper.Map<FornecedorResponseDto>(fornecedor);
        }

        public List<FornecedorResponseDto> Listar()
        {
            var fornecedores = _fornecedorDomainService.Listar();
            return _mapper.Map<List<FornecedorResponseDto>>(fornecedores);
        }

        public FornecedorResponseDto? Obter(int id)
        {
            var fornecedor = _fornecedorDomainService.Obter(id);
            if (fornecedor is null) return null;
            return _mapper.Map<FornecedorResponseDto>(fornecedor);
        }
    }
}
