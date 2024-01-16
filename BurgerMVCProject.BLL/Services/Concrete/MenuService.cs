using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Concrete
{
    public class MenuService
    {
        private readonly IMenuRepository menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            this.menuRepository = menuRepository;
        }

        public bool AddMenu(Menu menu)
        {
            var file = menu.Image;
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\\MenuPhotos", file.FileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }

            Menu menu1 = new()
            {
                Name = menu.Name,
                Price = menu.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = path
            };

            return menuRepository.Add(menu1);
        }

        public bool UpdateMenu(Menu menu)
        {
            var file = menu.Image;
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\MenuPhotos", file.FileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }

            Menu menu1 = new()
            {
                Name = menu.Name,
                Price = menu.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = path
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
    }
}
