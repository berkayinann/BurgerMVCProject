using BurgerMVCProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Abstract
{
    public interface IMenuService
    {
        List<Menu> GetMenus();
        bool AddMenu(Menu menu);
        bool UpdateMenu(Menu menu);
        bool DeleteMenu(Menu menu);
    }
}
