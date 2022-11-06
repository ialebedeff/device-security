using DeviceSecurity.Shared.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DeviceSecurity.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public string ConnectionString { get; private set; }
        public ApplicationContext(IConfiguration configuration) {
            ConnectionString = configuration.GetConnectionString("Default");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConnectionString);
        }
        public DbSet<Account> Accounts => Set<Account>();
    }
}