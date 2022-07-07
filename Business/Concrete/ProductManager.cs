using Business.Abstract;
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
            {
                return new ErrorResult("Ürün ismi minimum 2 karakter olmalı");
            }

            _productDal.Add(product);
            return new SuccessResult("Product is added");
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new Result(true);
        }

        //SOYUT NESLEYLE bağlantı kuracağız ne inmemory ne de ientity geçecek (geçmeyecek)
        public List<Product> GetAll()
        {
           
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {

            return _productDal.GetAll(p => p.CategoryId == id);

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }

        public Product GeyById(int productId)
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