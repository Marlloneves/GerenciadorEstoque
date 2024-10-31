using GerenciamentoPedidoEstoqueChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoPedidoEstoqueChallenge.InfraStructure.Configurations
{
    public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.HasKey(oi => oi.Id);
            builder.Property(oi => oi.Quantidade).IsRequired();
            builder.Property(oi => oi.PrecoUnidade).HasColumnType("decimal(18,2)");

            builder.HasOne(oi => oi.Pedido)
                   .WithMany(o => o.PedidoItens)
                   .HasForeignKey(oi => oi.PedidoId);
            builder.HasOne(oi => oi.Produto)
                   .WithMany(p => p.PedidoItens)
                   .HasForeignKey(oi => oi.ProdutoId);
        }
    }
}
