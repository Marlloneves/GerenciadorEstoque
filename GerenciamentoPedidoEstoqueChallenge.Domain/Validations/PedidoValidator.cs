using FluentValidation;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Validations
{
    public class PedidoValidator : AbstractValidator<Pedido>
    {
        public PedidoValidator()
        {
            RuleFor(p => p.PedidoData)
                .NotEmpty()
                .WithMessage("Por favor, insira uma data para o pedido.");

            RuleFor(p => p.Status)
                .MaximumLength(20)
                .WithMessage("O pedido deve ter no máximo 20 caracteres.");
        }
    }
}
