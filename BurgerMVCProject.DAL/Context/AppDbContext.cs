
using BurgerMVCProject.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BurgerMVCProject.Domain.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        private readonly DbContextOptions<AppDbContext> dbContext;

        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
        public DbSet<ExtraProduct> ExtraProducts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
