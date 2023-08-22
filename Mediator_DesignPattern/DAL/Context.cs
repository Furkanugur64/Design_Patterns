

using Microsoft.EntityFrameworkCore;

namespace Mediator_DesignPattern.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}
