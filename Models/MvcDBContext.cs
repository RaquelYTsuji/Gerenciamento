using Microsoft.EntityFrameworkCore;

namespace Aula29MVCDB.Models;

public class MvcDBContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    
    public DbSet<Pedido> Pedidos { get; set; }
    
    public MvcDBContext(DbContextOptions<MvcDBContext> options) : base(options)
    {
        
    }
}