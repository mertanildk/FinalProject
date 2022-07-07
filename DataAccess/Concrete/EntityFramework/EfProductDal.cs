using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthWindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            //şuan contexte ihtiyacımız var 
            using (NorthWindContext context = new NorthWindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };

                return result.ToList();
            }




        }
    }
}
//IProductDal şuanda kızmıyor çünkü IProductDal içersindeki operasyonlar EfEntityRepositoryBase'De var o yüzden kızmazzz
//EfProductDal  inherit ediliyor


//EfEntityRepositoryBase İÇERSİNDE ------ ,IProductDal OPERASYONLARI OLDUĞU İÇİN KIZMIYOR
//ŞUANDA BÜTÜN VERİTABANI OPERASYONLARI HAZIR.  EfEntityRepositoryBase<Product,NorthWindContext> İÇERİSİNDE HEPSİ

//IProductDal' a ne gerek var ??
//CEVAP içerisini(interface) ürüne ait özel operasyonları koyaacaz 
//örneğin ürün kategori tabloalrına join atmak için kulalnılır.
//bir de business IProductDal'a bağlı
//







//EntityFramework = EfEntityRepositoryBase<Product,NorthWindContext>
//bu bir entityFramework