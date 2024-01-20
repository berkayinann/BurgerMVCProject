using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Concrete
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }

        public bool AddMenu(Menu menu)
        {         
            Menu menu1 = new()
            {
                Name = menu.Name,
                Price = menu.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = menu.ImageSrc
            };

            return menuRepository.Add(menu1);
        }

        public bool UpdateMenu(Menu menu)
        {
            Menu menu1 = new()
            {
                Name = menu.Name,
                Price = menu.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = menu.ImageSrc
            };
            return menuRepository.Update(menu1);
        }

        public bool DeleteMenu(Menu menu)
        {
            return menuRepository.Delete(menu);
        }

        public List<Menu> GetMenus()
        {
            return menuRepository.GetAll().Select(s => new Menu()
            {
                MenuId = s.MenuId,
                Name = s.Name,
                ImageSrc = s.ImageSrc,
                Price = s.Price
            }).ToList();
        }

        public Menu GetByIdMenu(int id)
        {
            return menuRepository.GetById(id);
        }
    }
}
