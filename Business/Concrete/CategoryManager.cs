using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;//bağımlılığımızı minimize ediyoruz

        public CategoryManager(ICategoryDal categoryDal)//constacter injection
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category categoryId)
        {
            _categoryDal.Delete(categoryId);
        }

        public List<Category> GetAll()
        {
            //iş kodları 
            return _categoryDal.GetAll();
           
        }

        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);  
        }

        public void Update(Category category)
        {
             _categoryDal.Update(category);
        }
    }
}
