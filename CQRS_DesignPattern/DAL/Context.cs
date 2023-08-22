using Microsoft.EntityFrameworkCore;

namespace CQRS_DesignPattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FRKN\\SQLEXPRESS;initial Catalog=CasgemCQRS;integrated Security=true");
        }

        public DbSet<Product> Products { get; set; }
    }
}
