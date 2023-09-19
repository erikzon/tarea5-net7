using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class Conexion : DbContext
    {
        public Conexion(DbContextOptions<Conexion> options)
            : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; } = null!;
    }
}