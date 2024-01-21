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
            ExtraProduct eProduct = new()
            {
                Name = extraProduct.Name,
                Price = extraProduct.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = extraProduct.ImageSrc
            };

            return EProductRepository.Add(eProduct);
        }

        public bool UpdateEProduct(ExtraProduct extraProduct)
        {            
            ExtraProduct eProduct = new()
            {
                Name = extraProduct.Name,
                Price = extraProduct.Price,
                CreatedDate = DateTime.Now,
                ImageSrc = extraProduct.ImageSrc
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
                ExtraProductId = s.ExtraProductId,
                Name = s.Name,
                ImageSrc = s.ImageSrc,
                Price = s.Price,
                Category=s.Category,
            }).ToList();
        }

        public ExtraProduct GetByIdProduct(int id)
        {
            return EProductRepository.GetById(id);
        }
    }
}
