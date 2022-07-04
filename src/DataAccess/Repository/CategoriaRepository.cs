using Business.Intefaces;
using Business.Models;
using DataAccess.Data;

namespace Data.Repository;

public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(ApplicationDbContext db) : base(db) { }
}
