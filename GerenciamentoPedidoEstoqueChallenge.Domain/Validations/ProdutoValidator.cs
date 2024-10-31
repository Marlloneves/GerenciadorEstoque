using FluentValidation;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Validations
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .WithMessage("Por favor, insira um nome.")
                .Length(2, 100)
                .WithMessage("O nome deve ter no mínimo 2 e no máximo 100 caracteres.");

            RuleFor(p => p.QuantidadeEstoque)
                .NotEmpty()
                .WithMessage("Por favor, informe a quantidade de produto em estoque.");
        }
    }
}
