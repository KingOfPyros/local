using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class LocalHostContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=unitofworks_db;Trusted_Connection=True;");
        }
    }
}
