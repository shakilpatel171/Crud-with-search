using Microsoft.EntityFrameworkCore;

namespace Sdaemon.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option ) : base(option)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<HrModel> HrModels { get; set; }
    }
}
