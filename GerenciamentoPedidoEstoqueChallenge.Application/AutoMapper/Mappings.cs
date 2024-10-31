using AutoMapper;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Application.AutoMapper
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            //Cliente
            CreateMap<Cliente, ClienteRequestDto>().ReverseMap();
            CreateMap<Cliente, ClienteResponseDto>().ReverseMap();

            //Fornecedor
            CreateMap<Fornecedor, FornecedorRequestDto>().ReverseMap();
            CreateMap<Fornecedor, FornecedorResponseDto>().ReverseMap();

            //Pedido
            CreateMap<Pedido, PedidoRequestDto>().ReverseMap();
            CreateMap<Pedido, PedidoResponseDto>().ReverseMap();

            //PedidoItem
            CreateMap<PedidoItem, PedidoItemRequestDto>().ReverseMap();
            CreateMap<PedidoItem, PedidoItemResponseDto>().ReverseMap();

            //Produto
            CreateMap<Produto, ProdutoRequestDto>().ReverseMap();
            CreateMap<Produto, ProdutoResponseDto>().ReverseMap();

            //Usuário
            CreateMap<Usuario, UsuarioRequestDto>().ReverseMap();
            CreateMap<Usuario, UsuarioResponseDto>().ReverseMap();
        }
    }
}
