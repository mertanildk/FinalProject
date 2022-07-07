using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product> //DAL HANGİ KATMANA KARŞILIK GELDİĞİNİ ANLATIR 
    {

        List<ProductDetailDto> GetProductDetails(); //Producta özel kod yazabilmemiz için IproductDal var


        //YANİ PRODUCT TABLOSUNUN DAL'I O DA == DATA ACCESS LAYER 
        //SEKTÖRDE DAL VEYA DAO KULLANILIR İKİSİ DE AYNIDIR.
        //JAVADA GENELDE DAO. AMA .NETDE DE KULLANILIR 
        //operasyonlar (şunu ekle sil kaldır indir  işlemleri)
        //interfacelerin operasyonları public kendisi değil 

       
        //ürünleri kategoriye göre filtrele
        //e tiraret sitesinde kategorilere bastığın zaman çalışacak kod bu 
        //interfaceye yazdık 








    }
}


//code refaktoring kodun iyileştirilmesi.