using FluentValidation;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Validations
{
    public class FornecedorValidator :AbstractValidator<Fornecedor>
    {
        public FornecedorValidator()
        {
            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("Por favor, insira um nome.")
                .Length(2, 100)
                .WithMessage("O nome deve ter no mínimo 2 e no máximo 100 caracteres.");

            RuleFor(c => c.Telefone)
                .MaximumLength(15)
                .WithMessage("O telefone deve ter no máximo 15 caracteres.");
        }
    }
}
