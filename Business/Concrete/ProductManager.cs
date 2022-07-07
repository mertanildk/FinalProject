using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService//manager görürsen anla ki o iş katmanının somut sınıfı 
    {
        //bir iş sınıfı başka sınıfları newlemez

        IProductDal _productDal;//injection
        //bildiği tek şey ıProductDAl olacak.

        public ProductManager(IProductDal productDal)//injection
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if (product.ProductName.Length<2)
            {//magic strings = bunları böyle yazarsan, bir değişiklik olduğunda her yerden değiştirmek zorunda kalırsn
                return new ErrorResult(Messages.ProductNameInValid);
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new Result(true);
        }

        //SOYUT NESLEYLE bağlantı kuracağız ne inmemory ne de ientity geçecek (geçmeyecek)
        public IDataResult<List<Product>> GetAll()
        {
           
            return new DataResult<List<Product>>(_productDal.GetAll(),true,"ürünler listelendi");
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {

            return _productDal.GetAll(p => p.CategoryId == id);

        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public IDataResult<List<Product>> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public IDataResult<Product> GeyById(int productId)
        {

            return _productDal.Get(p => p.ProductId == productId);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new Result(true);
        }
    }
}


//Bir metot sadece bir değer dönürebilir
//bunu değiştirmek için ENCAPSULATION yapılacak
//