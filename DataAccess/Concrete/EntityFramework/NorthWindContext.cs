using Core.Entities.Concrete;
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

        public DbSet<Product> Products { get; set; }//BAĞLADIK
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Personel> Personels { get; set; } //şuanda eşleştirebileceği bir database yok. Biz Employee ile eşleitmek istiyoruz
        public DbSet<Order> Orders { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //fluent mapping . olarak devam ettirebilirsin. 28. satırdan ama düzgün olsun diye alt alta yazıyoruz
            //modelBuilder.HasDefaultSchema("admin");                     //yazmana gerek yok dbo
            modelBuilder.Entity<Personel>().ToTable("Employees", "dbo");//Employees tablosuna bağlama kodu. default olarak 'dbo' gelir
            modelBuilder.Entity<Personel>().Property(p => p.id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.Name).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.Surname).HasColumnName("LastName");
        }


    }

    //@ koyduğumuzda normal ters \ yaptığımızı gör diyoruz.
    //KULLANICI ADI ŞİFRESİ GEREKMEDEN GİRİŞ YAPMAMIZI SAĞLIYOR  Trusted_Connection=true
    //ASLINDA DOĞRUSU BUDUR AMA GERÇEK SİSTEMLERDE KULLANICI ADI VE ŞİFRE DE GÖREBİLİRİZ.
    //INTEGRATED SECURY TRUE İLE AYNI ŞEY Trusted_Connection=true
    //HANGİ VERİTABANINA BAĞLANACAĞINI BULDUK ----CONTEXT-----
    //ŞİMDİ NESNELERİ BİRBİRİNE BAĞLAYACAĞIZ








}
