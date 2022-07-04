using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Business.Models;

namespace DataAccess.Mappings;

public class PedidoMapping : EntityMapping<Pedido>
{
    private static string _nameTable = "Pedido";
    public PedidoMapping() : base(_nameTable) { }
    public override void Configure(EntityTypeBuilder<Pedido> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.UsuarioId).HasMaxLength(150);
        builder.Property(x => x.DataPedido);
        builder.Property(x => x.ValorTotal);
        builder.Property(x => x.StatusPedido).HasMaxLength(150);
        builder.Property(x => x.StatusPagamento).HasMaxLength(150);
        builder.Property(x => x.Telefone).HasMaxLength(150);
        builder.Property(x => x.Endereco).HasMaxLength(150);
        builder.Property(x => x.Cidade).HasMaxLength(150);
        builder.Property(x => x.Estado).HasMaxLength(150);
        builder.Property(x => x.CEP).HasMaxLength(150);
        builder.Property(x => x.Nome).HasMaxLength(150);
    }
}
