using Business.Abstract;
using Core.Utilities.Results;
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

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category categoryId)
        {
            _categoryDal.Delete(categoryId);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
            //iş kodları 
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());

        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
