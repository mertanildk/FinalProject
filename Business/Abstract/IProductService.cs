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
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();
        Product GeyById(int productId);
        IResult Add(Product product);
        
        IResult Update(Product product);
        IResult Delete(Product product);


    }
}


//WEP API RESTFULL DEDİĞİMİZ BİR FORMAT GENELDE JSON'SUN 
//DİĞER UYGULAMALAR DA ANLASIN DİYE KULLANILIR.
//UYGULAMALAR REQUEST ATAR WEP'APİYE
//VERİLEN YANIT RESPONSE'DİR
