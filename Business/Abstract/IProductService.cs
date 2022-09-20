using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService //İŞ KATMANINDA KULLANACAĞIMIZ SRVİS KATMANI 
    {
        IDataResult<List<Product>> GetAll(); //bir data döndürüyorsa sadece Result yazamayız.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        
        IResult Update(Product product);
        IResult Delete(Product product);

        IResult AddTransactionalTest(Product product);


    }
}


//WEP API RESTFULL DEDİĞİMİZ BİR FORMAT GENELDE JSON'SUN 
//DİĞER UYGULAMALAR DA ANLASIN DİYE KULLANILIR.
//UYGULAMALAR REQUEST ATAR WEP'APİYE
//VERİLEN YANIT RESPONSE'DİR
