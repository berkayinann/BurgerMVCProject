using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Concrete
{
    //EMİNDEĞİLİZ
    public class CategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        //public bool AddCategory(Category category)
        //{

        //}
    }
}
