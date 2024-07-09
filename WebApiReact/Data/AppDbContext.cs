using Microsoft.EntityFrameworkCore;
using WebApiReact.Models;

namespace WebApiReact.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Users { get; set; }
    }
}
