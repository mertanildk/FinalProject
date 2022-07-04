using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal  //
    {

        List<Product> _products;//bu tip değişkenlere global değişken deniyor 
        public InMemoryProductDal()//constacter
        {


            _products = new List<Product>()
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            //BU KOD BİREBİR AYNISI OLSA BİLE SİLİNMEZ
            //ÇÜNKÜ ARAYÜZDEN GÖNDERDİĞİN PRODUCT'IN BİLGİLERİNİN AYNI OLMASI ÖNEMLİ DEĞİL
            //REFERANS TİPİ OLDUĞU İÇİN SİLEMEZSİN. REFERANS GÖNDERİYORUZ O YÜZDEN SİLİNMİYOR.
            //ÖRNEĞİN LİSTEMİZDE 101,102,103 RERERANSLI OBJELER OLSUN. 101 İLE BİREBİR AYNI BİLGİLER 200 REFERANS İLE GÖNDERİLDİĞİ İÇİN SİLİNMEZ
            //Product product = new Product();//BU ÇOK HATALIDIR ÇÜNKÜ SEN NEW DEDİĞİN İÇİN YENİ Bİ REFERANS ALIRSIN NEWLEME YAPMA 

            //LINQ =LANGUAGE INTEGRATED QUERY
            //LAMBDA => İŞARETİDİR...
            //genelde ID aramalarında singleordefault kulalnılır
            //first firstordefault kullansan da olur 
            //idler de sıkıntı varsa single hata veriyor 

            Product productToDelete=_products.SingleOrDefault(p=>p.ProductId==product.ProductId);
           
           _products.Remove(product); // ŞUAN NET BİR ŞEKİLDE SİLME İŞLEMİ GERÇEKLEŞİR
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;//veri tabanına olduğu gibi döndürüyoruz..
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)//camel case yazıyoruz 
        {
            
            return _products.Where(p => p.CategoryId == categoryId).ToList();

            // burada istediğin kadar kategory ekleyebilirsin. && yaparak
            //where içindeki şarta uyan bütün elemanları yeni bir liste haline getirir ve döndürür.
        }

        public void Update(Product product)
        {   // Gönderdiğim ürünID'sine sahip olan listedeki ürünü bul demek
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            //id değiştirmeye gerek yok zaten değişmemeli
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock; //güncellendi artık 

            //gerçek hayat projerinde entityframework, enhyberNey gibi TEKNOLOJİLERİ kullanırz
        }
    }
}
