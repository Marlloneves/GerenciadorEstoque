using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using GerenciamentoPedidoEstoqueChallenge.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace GerenciamentoPedidoEstoqueChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorAppService _fornecedorAppService;

        public FornecedorController(IFornecedorAppService fornecedorAppService)
        {
            _fornecedorAppService = fornecedorAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(FornecedorResponseDto), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Inserir([FromBody] FornecedorRequestDto fornecedorRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var fornecedorCriado = _fornecedorAppService.Inserir(fornecedorRequestDto);

            return CreatedAtAction(nameof(ObterFornecedor), new { id = fornecedorCriado.Id }, fornecedorCriado);
        }

        [HttpGet("Obter-Fornecedor/{id}")]
        [ProducesResponseType(typeof(FornecedorResponseDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult ObterFornecedor(int id)
        {
            var fornecedor = _fornecedorAppService.Obter(id);
            if (fornecedor is null)
                return NotFound();
            return Ok(fornecedor);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<FornecedorResponseDto>), 200)]
        public IActionResult ObterTodos()
        {
            var fornecedor = _fornecedorAppService.Listar();
            return Ok(fornecedor);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(FornecedorResponseDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public IActionResult Atualizar(int id, [FromBody] FornecedorRequestDto fornecedorRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var fornecedorAtualizado = _fornecedorAppService.Atualizar(id, fornecedorRequestDto);
            if (fornecedorAtualizado is null)
                return NotFound();

            return Ok(fornecedorAtualizado);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Deletar(int id)
        {
            var fornecedorRemovido = _fornecedorAppService.Excluir(id);
            if (fornecedorRemovido is null)
                return NotFound();

            return Ok(fornecedorRemovido);
        }
    }
}
