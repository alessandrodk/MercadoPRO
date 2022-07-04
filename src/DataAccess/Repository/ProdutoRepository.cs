using Business.Intefaces;
using Business.Models;
using DataAccess.Data;

namespace Data.Repository;

public class ProdutoRepository : Repository<Produto>, IProdutoRepository
{
    public ProdutoRepository(ApplicationDbContext db) : base(db) { }
}
