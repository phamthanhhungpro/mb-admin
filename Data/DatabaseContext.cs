using mbadmin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

namespace mbadmin.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<MailLog> MailLog { get; set; }
        public DbSet<InfoLog> InfoLog { get; set; }
        public DbSet<ScamCheckerLog> ScamCheckerLog { get; set; }
        public DbSet<VideodlLog> VideodlLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
