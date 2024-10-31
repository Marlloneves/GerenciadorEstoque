using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Configurations
{
    public class FornecedorConfiguration : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Telefone).HasMaxLength(15);
        }
    }
}
