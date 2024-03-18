using HomePropertiesProject.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomePropertiesProject.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<House> Houses { get; set; } = default!;
        public DbSet<Mode> Modes { get; set; } = default!;
    }
}
