
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
