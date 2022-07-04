using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
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

        //SOYUT NESLEYLE bağlantı kuracağız ne inmemory ne de ientity geçecek (geçmeyecek)
        public List<Product> GetAll()
        {
            //iş kodları
            //yetkisi var mı ?
            //geçerse döndür...
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
    }
}
