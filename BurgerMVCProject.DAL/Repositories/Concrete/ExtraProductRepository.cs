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
    public class ExtraProductRepository : GenericRepository<ExtraProduct>, IExtraProductRepository
    {
        private readonly AppDbContext dbContext;

        public ExtraProductRepository(AppDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
