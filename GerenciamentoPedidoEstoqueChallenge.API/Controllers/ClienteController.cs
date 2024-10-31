using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Requests;
using GerenciamentoPedidoEstoqueChallenge.Application.Dtos.Responses;
using GerenciamentoPedidoEstoqueChallenge.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoPedidoEstoqueChallenge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService _clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            _clienteAppService = clienteAppService;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ClienteResponseDto), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Inserir([FromBody] ClienteRequestDto clienteRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clienteCriado = _clienteAppService.Inserir(clienteRequestDto);

            return CreatedAtAction(nameof(ObterCliente), new { id = clienteCriado.Id }, clienteCriado);
        }

        [HttpGet("Obter-Cliente/{id}")]
        [ProducesResponseType(typeof(ClienteResponseDto), 200)]
        [ProducesResponseType(404)]
        public IActionResult ObterCliente(int id)
        {
            var cliente = _clienteAppService.Obter(id);
            if (cliente is null)
                return NotFound();

            return Ok(cliente);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ClienteResponseDto>), 200)]
        public IActionResult ObterTodos()
        {
            var clientes = _clienteAppService.Listar();
            return Ok(clientes);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ClienteResponseDto), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        public IActionResult Atualizar(int id, [FromBody] ClienteRequestDto clienteRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clienteAtualizado = _clienteAppService.Atualizar(id, clienteRequestDto);
            if (clienteAtualizado is null)
                return NotFound();

            return Ok(clienteAtualizado);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(404)]
        public IActionResult Deletar(int id)
        {
            var clienteRemovido = _clienteAppService.Excluir(id);
            if (clienteRemovido is null)
                return NotFound();

            return Ok(clienteRemovido);
        }
    }
}
