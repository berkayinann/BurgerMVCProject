using BurgerMVCProject.Domain.Context;
using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.Concrete
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        private readonly AppDbContext dbContext;

        public MenuRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
