using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Concrete
{
    public class ExtraProductService
    {
        private readonly IExtraProductRepository repository;
        public ExtraProductService(IExtraProductRepository repository)
        {
            this.repository = repository;
        }
    }
}
