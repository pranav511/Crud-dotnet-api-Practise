using Microsoft.EntityFrameworkCore;

namespace Crud_dotnet_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Employee> Employees { get; set; }

    }
}
