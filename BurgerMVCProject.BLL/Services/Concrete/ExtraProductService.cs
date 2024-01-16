using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Concrete
{
    public class ExtraProductService : IExtraProductService
    {
        private readonly IExtraProductRepository EProductRepository;

        public ExtraProductService(IExtraProductRepository EProductrepository)
        {
            this.EProductRepository = EProductrepository;
        }

        public bool AddEProduct(ExtraProduct extraProduct)
        {
            var file = extraProduct.Image;
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\\MenuPhotos", file.FileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }

            ExtraProduct eProduct = new()
            {
                Name = extraProduct.Name,
                Price = extraProduct.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = path
            };

            return EProductRepository.Add(eProduct);
        }

        public bool UpdateEProduct(ExtraProduct extraProduct)
        {
            var file = extraProduct.Image;
            string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\MenuPhotos", file.FileName);

            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                file.CopyToAsync(fileStream);
            }

            ExtraProduct eProduct = new()
            {
                Name = extraProduct.Name,
                Price = extraProduct.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = path
            };
            return EProductRepository.Update(eProduct);
        }

        public bool DeleteEProduct(ExtraProduct extraProduct)
        {
            return EProductRepository.Delete(extraProduct);
        }

        public List<ExtraProduct> GetEProducts()
        {
            return EProductRepository.GetAll().Select(s => new ExtraProduct()
            {
                MenuId = s.MenuId,
                Name = s.Name,
                ImageSrc = s.ImageSrc,
                Price = s.Price
            }).ToList();
        }

    }
}
