using Microsoft.EntityFrameworkCore;
using RegistroDetran.Core.Entities;

namespace RegistroDetran.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LogEntry> Logs { get; set; }
    }
}
