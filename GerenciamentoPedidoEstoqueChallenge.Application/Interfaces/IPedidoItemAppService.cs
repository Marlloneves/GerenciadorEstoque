﻿using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;

namespace GerenciamentoPedidoEstoqueChallenge.Application.Interfaces
{
    public interface IPedidoItemAppService : IBaseAppService<PedidoItemRequestDto, PedidoItemResponseDto>
    {
    }
}