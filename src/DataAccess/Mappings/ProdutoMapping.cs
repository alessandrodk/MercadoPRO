using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Business.Models;

namespace DataAccess.Mappings;
public class ProdutoMapping : EntityMapping<Produto>
{
    private static string _nameTable = "Produto";
    public ProdutoMapping() : base(_nameTable) { }
    public override void Configure(EntityTypeBuilder<Produto> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Nome).HasMaxLength(150);
        builder.Property(x => x.Descricao).HasMaxLength(150);
        builder.Property(x => x.Valor);
        builder.Property(x => x.ImagemUrl).HasMaxLength(150);
        builder.Property(x => x.Quantidade);
        builder.Property(x => x.CategoriaId);
        builder.Property(x => x.DataCadastro);

        builder
            .HasOne(x => x.Categoria)
            .WithMany(op => op.Produtos)
            .HasForeignKey(x => x.CategoriaId);

        builder.HasData(
         new Produto { Id = 1, CategoriaId = 1, Descricao = "Camisa", Nome = "Camisa", Quantidade = 3, Valor = 10m },
         new Produto { Id = 2, CategoriaId = 1, Descricao = "Short", Nome = "Short", Quantidade = 3, Valor = 10m },
         new Produto { Id = 3, CategoriaId = 2, Descricao = "Tênis", Nome = "Tênis", Quantidade = 3, Valor = 10m },
         new Produto { Id = 4, CategoriaId = 2, Descricao = "Sapato", Nome = "Sapato", Quantidade = 3, Valor = 10m }
     );
    }
}
