using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Business.Models;

namespace DataAccess.Mappings;

public class CategoriaMapping : EntityMapping<Categoria>
{
    private static string _nameTable = "Categoria";
    public CategoriaMapping() : base(_nameTable) { }
    public override void Configure(EntityTypeBuilder<Categoria> builder)
    {
        base.Configure(builder);

        builder.Property(x => x.Descricao).HasMaxLength(150);
        builder.Property(x => x.DataCadastro);

        builder.HasData(
            new Categoria {Id = 1, Descricao = "Roupa" },
            new Categoria {Id = 2, Descricao = "Calçado" },
            new Categoria {Id = 3, Descricao = "Caneca" },
            new Categoria {Id = 4, Descricao = "Outros" }
        );


     
    }
}
