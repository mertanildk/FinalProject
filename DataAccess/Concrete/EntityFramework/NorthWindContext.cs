using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthWindContext : DbContext//BU ENTITYFRAMEWORK'DEN GELDİ
    {
        //BU metot bizim proje hangi veritabanı ile ilişkili olduğunu belirttiğimiz yer
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");//sqlserver kullanıcaz.//burada hangi veritabanına bağlanacağımızı söyleyecez
        }

        public DbSet<Product> Products { get; set; }//BAĞLAMA
        public DbSet<Category> Categories { get; set;  }
        public DbSet<Customer> Customers { get; set; }

    }

    //@ koyduğumuzda normal ters \ yaptığımızı gör diyoruz.
    //KULLANICI ADI ŞİFRESİ GEREKMEDEN GİRİŞ YAPMAMIZI SAĞLIYOR  Trusted_Connection=true
    //ASLINDA DOĞRUSU BUDUR AMA GERÇEK SİSTEMLERDE KULLANICI ADI VE ŞİFRE DE GÖREBİLİRİZ.
    //INTEGRATED SECURY TRUE İLE AYNI ŞEY Trusted_Connection=true
    //HANGİ VERİTABANINA BAĞLANACAĞINI BULDUK ----CONTEXT-----
    //ŞİMDİ NESNELERİ BİRBİRİNE BAĞLAYACAĞIZ








}
