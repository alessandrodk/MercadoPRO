using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Business.Models;

namespace DataAccess.Mappings;

public class PedidoDetalheMapping : EntityMapping<PedidoDetalhe>
{
    private static string _nameTable = "PedidoDetalhe";
    public PedidoDetalheMapping() : base(_nameTable) { }
    public override void Configure(EntityTypeBuilder<PedidoDetalhe> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.PedidoId);
        builder.Property(x => x.ProdutoId);
        builder.Property(x => x.Quantidade);
        builder.Property(x => x.Valor);

        builder
            .HasOne(x => x.Produto)
            .WithMany(op => op.PedidoDetalhes)
            .HasForeignKey(x => x.ProdutoId);

        builder
            .HasOne(x => x.Pedido)
            .WithMany(op => op.PedidoDetalhes)
            .HasForeignKey(x => x.PedidoId);
    }
}