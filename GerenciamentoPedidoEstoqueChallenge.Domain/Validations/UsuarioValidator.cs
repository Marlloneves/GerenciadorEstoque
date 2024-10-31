using FluentValidation;
using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;

namespace GerenciamentoPedidoEstoqueChallenge.Domain.Validations
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Nome)
                .NotEmpty()
                .WithMessage("Insira um nome para o Usuário")
                .Length(2, 100)
                .WithMessage("O tamanho recomendado é de no mínimo 2 e no máximo 100 caracteres.");

            RuleFor(u => u.DataNascimento)
                .NotEmpty()
                .WithMessage("Insira uma data de nascimento para o Usuário.");

            RuleFor(c => c.Telefone)
                .MaximumLength(15)
                .WithMessage("O telefone deve ter no máximo 15 caracteres.");
        }
    }
}
