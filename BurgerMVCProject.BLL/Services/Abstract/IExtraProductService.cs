using BurgerMVCProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Abstract
{
    public interface IExtraProductService
    {
        List<ExtraProduct> GetEProducts();
        ExtraProduct GetByIdProduct(int id);
        bool AddEProduct(ExtraProduct extraProduct);
        bool UpdateEProduct(ExtraProduct extraProduct);
        bool DeleteEProduct(ExtraProduct extraProduct);
    }
}
