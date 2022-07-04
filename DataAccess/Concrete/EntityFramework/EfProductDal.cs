using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        //refaktor =iyileştirme
        public void Add(Product entity)
        {
            //bir classı newlediğinizde garbage collector belli bir zamanda gelir ve bellekten siler 
            //using içnie yazılan nesneler using bitince anında garbage collectore geliyor.
            //neden çünkü context nesnesi biraz pahalı.(/ağır)

            using (NorthWindContext context =new NorthWindContext())//c#'a özel bir yapı //using bittiği anda garbage collector çalışır.
            {
                var addedEntity = context.Entry(entity);//entry bu frameworke özel. Git veri kaynağından benim gönderdiğim product'a bir nesne eşleştir.
                //burada referansı yakaladık
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthWindContext context= new NorthWindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter); //STANDART GÖRDÜĞÜMÜZ YERDE GENERİC BASE YAPILIR AMA ONU ŞİMDİ GÖRMEYECEZ
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthWindContext context=new NorthWindContext())
            {
                return filter == null 
                    ? context.Set<Product>().ToList() 
                    : context.Set<Product>().Where(filter).ToList();
            }
        }

        public void Update(Product entity)
        {
            using (NorthWindContext context = new NorthWindContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;//GÜNCELLE demektir
                context.SaveChanges();
            }
        }
    }
}
