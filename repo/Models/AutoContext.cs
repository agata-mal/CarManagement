using System.Data.Entity;

namespace repo.Models
{
    public class AutoContext : DbContext
    {
        public AutoContext() : base("AutoConnection")
        {
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Worker> Workers { get; set; }
    }

}