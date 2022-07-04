using Business.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoDetalhe> PedidoDetalhes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    foreach (var property in modelBuilder.Model.GetEntityTypes()
        //        .SelectMany(e => e.GetProperties()
        //            .Where(p => p.ClrType == typeof(string))))
        //        property.SetColumnType("varchar");

        //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        //    foreach (var relationship in modelBuilder.Model.GetEntityTypes()
        //        .SelectMany(e => e.GetForeignKeys()))
        //        relationship.DeleteBehavior = DeleteBehavior.Cascade;

        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var stringConexao = @$"server=DESKTOP-SNP9CO7\SERVER2019;database=MercadoPRO;user=sa;password=desenvolvedor";
        //    optionsBuilder.UseSqlServer(stringConexao);
        //}

        //public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
        //    {
        //        if (entry.State == EntityState.Added)
        //            entry.Property("DataCadastro").CurrentValue = DateTime.Now;

        //        if (entry.State == EntityState.Modified)
        //            entry.Property("DataCadastro").IsModified = false;
        //    }

        //    return base.SaveChangesAsync(cancellationToken);
        //}
    }
}
