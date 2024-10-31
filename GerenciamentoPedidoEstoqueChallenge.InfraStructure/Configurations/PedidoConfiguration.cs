using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.PedidoData).IsRequired();
            builder.Property(o => o.Status).HasMaxLength(20);
            builder.HasOne(o => o.Cliente)
                   .WithMany(c => c.Pedidos)
                   .HasForeignKey(o => o.ClienteId);
        }
    }
}
