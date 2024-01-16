using BurgerMVCProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Abstract
{
    public interface ICategoryService
    {
        Category GetByIdCategory(int id);
    }
}
