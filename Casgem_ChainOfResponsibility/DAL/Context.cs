using Microsoft.EntityFrameworkCore;

namespace Casgem_ChainOfResponsibility.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FRKN\\SQLEXPRESS;initial Catalog=CasgemDBCoR;integrated Security=true");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
