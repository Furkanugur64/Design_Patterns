using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Observer_DesignPattern.DAL
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=FRKN\\SQLEXPRESS;initial Catalog=CasgemObserver;integrated Security=true");
        }

        public DbSet<Discount>  Discounts { get; set; }
        public DbSet<UserProcess>  UserProcesses { get; set; }
        public DbSet<WelcomeMessage>  WelcomeMessages { get; set; }
      
    }
}
