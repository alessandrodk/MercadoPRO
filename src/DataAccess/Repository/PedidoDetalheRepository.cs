using Business.Intefaces;
using Business.Models;
using DataAccess.Data;


namespace Data.Repository;

public class PedidoDetalheRepository : Repository<PedidoDetalhe>, IPedidoDetalheRepository
{
    public PedidoDetalheRepository(ApplicationDbContext db) : base(db) { }
}
