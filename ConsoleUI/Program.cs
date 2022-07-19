using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //abstact içine referans tutucu  abstact nesneleri soyut nesneleri interfaceleri baseclassları hepsi burada olur soyut
            //somutlar ise (concrete) gerçek işi yapanları buraya koyacaz 
            //abstact içine referans tutucu interface abstract vb
            //concrete içine 
            //abstact ile uygulamalar arası bağımılılkları minimize edecez 
            //abstract da önce interface oluşmalı 
            //iş yapan classları oluştuluacağı zaman bir interface yoksa 
            //her zaman ama her zaman interfacesini oluştur.
            //gerek olmasa bile oluştur
            //bugün gerek olmaz ama yarın olabilir 




            //DATA ACCESS-CONCRETE DOSYASSI İÇİNDEKİ DOSYALAR DATA ACCESS DE GÖSTERİLEN X Y Z OLANLARDAN BAZILARI DATAYA ULAŞAN.. BURAYI BİR DAHA DİNLE YA
            //data access  alternatif yöntemler vardır x y z gibi 
            //alternatif bir teknolojisi olan bir ortamı kodluyorsak orada klasörleme tekniğine gidiyoruz....
            //inmoery ve entitiyframework alternatif 

            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + " --><-- " + product.CategoryName);
                }

            }
            else
            {
                Console.WriteLine(result.Message);
            }


            //PersonelManager personelManager = new PersonelManager(new EfPersonelDal());
            ////personelManager.Add(new Personel { Name = "asd", Surname = "dede" });
            //Personel sil = personelManager.Get(12);
            //personelManager.Delete(sil);

            //foreach (var personel in personelManager.GetAll())
            //{
            //    Console.WriteLine("{0} --- {1} --- {2}",personel.id, personel.Name,personel.Surname);//MAPPING TAMAMLANDI
            //}


            //ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetByUnitPrice(40,100))
            //{
            //    Console.WriteLine(product.ProductName);
            //}




            //ENTITYFRAMEWORK
            //Microsoftun bir ürünü Object ERM
            //LİNQ DESTEKLİ ÇALIŞIYOR
            //OERM DEMEK VERİTABANINDAKİ TABLOYU SANKİ CLASSMIŞ GİBİ ONUNLA İLİŞİKLENİDİRİP BUNDAN SONRA BÜTÜN SQLLERİ LİNQ İLE YAPTIĞMIIZ BİR ORTAM
            //OERM VERİTABANI NESNELERİ İLE KODLAR ARASINDA BİR BAĞ KURUP VERİTABANI İŞLERİNİ YAPMA SÜRECİ.

            //DİĞER İNSANLARIN YAZDIĞI, KOYULDUĞU VE YÖNETİLDİĞİ BİR ORTAM VAR 
            //BU ORTAMIN ADI NuGet burada diğer insanların da yazmış olduğu kodlar vardır. Bunlara PAKET DENİR.




            //Veritabanındaki tablolar ile 
            //kendi tablolarımızı ilişkilendirmemiz gerekiyor 
            //bu işlemi gerçekleştirmek için kontex dediğimiz yapıyı kuruyoruz
            //Context demek veritabanı ile kendi classlarımızı ilişkilendirdiğmiiz classtır
            //Context DB TABLOLARI İLE PROJE CLASSLARINI BAĞLAMAK







            //İŞ MÜLATINA GİDERSEN SOLID 
            //0 = OPEN CLOSED PRINCIPE
            //yaptığın yazılıma yeni bir özellik ekliyorsan mevcuttaki hiç bir koduna dokunamazsın
            //
        }
    }
}


//asp.net microsoftun web geliştirme ortamının ve bunları içeren kütüphanelerin toplandığı yapıdır.
//projeyi ne ile geliştirdin derlerse
//.net ile veya asp.net ile 
//.net onun framework'u asp.net ise o framework içerisinde  geliştirebilecğimiz bir proje türünü anlatır
//asp.net , .net projelerindeki web projelerine verilen isim.
//wep api ne işe yarıyor
//api bir restfull mimariyi destekler
//restfull mimari ile çalışma imkanı sağlar

//restful yapılar karşımıza http protokolü sayesinde geliyor
//restful --> HTTP --> TCP(KABLOLU) 

//controller, bizim sistemimizi kullanacak clientler(mobil, masaüstü,angiler vb.) hangi operasyonlar için ve nasıl istekte
//bulunabilir sorularını biz controllers'de yazıyoruz.
//