using Business.Intefaces;
using Business.Models;
using Data.Repository;
using DataAccess.Data;

namespace Repository;
public class PedidoRepository : Repository<Pedido>, IPedidoRepository
{
    public PedidoRepository(ApplicationDbContext db) : base(db) { }
}
