using BurgerMVCProject.UI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.Domain.Context
{
    internal class AppDbContext : IdentityDbContext<AppUser>
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
