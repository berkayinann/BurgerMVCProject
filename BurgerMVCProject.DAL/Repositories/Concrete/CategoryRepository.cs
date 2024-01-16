using BurgerMVCProject.Domain.Context;
using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    internal class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        private readonly AppDbContext dbContext;

        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
