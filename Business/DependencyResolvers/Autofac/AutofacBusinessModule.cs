using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.CCS;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //services.AddSingleton<IProductService, ProductManager>() AYNI ANLAAMA GELİYOR İKİSİ.
            builder.RegisterType<ProductManager>().As<IProductService>().SingleInstance();
            builder.RegisterType<EfProductDal>().As<IProductDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();

            //tek bir instance oluştur 
            //webapinin kendi startupp var ama bizimkini kullanmasını istyiyoruz.
            //çünkü ileride başka bir webapi gelirse orası için de dinamiklik sağlayabiliriz.



            //autofac'den de vazgeçersen eğer, çok basit bir yolu var
            //yeni bir klasör açıp (dependencyResolvers altına),
            //program.cs(yeni apinin) içine gelip builder.register içini ve
            //use service providerfactory içini değiştirmek.




            // 



        }
    }
}
