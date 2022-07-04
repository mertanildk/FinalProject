using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class ,IEntity,new()
        //CLASS REFERANS TİP class olan class değil. referans tip demektir şuanda.
        //GENERİC KULLANDIK artık ne gönderirsek o.
    {   //İSTİYORUZ Kİ SADECE VERİTABANI NESNELERİ OLSUN....
        //SADECE <T> YAZILDIĞINDA İSTENİLEN YAZILABİLİYOR
        //BUNUN ÖNNÜE GEÇMEK İÇİN
        //GENERİC CONSTRAIN =GENERİC KISIT. KOYUYORUZ....
        //EXPRESSİON
        //where T class yazarsak, herhangi bir class yazılabilir. ama biz bunu da istmiyoruz sadece kendi verdiğimiz classların yazılabilmesini istiyoruz.
        //where T : class ,IEntity BUNU YAZDIK VE OLAY ŞU = IENTITY OLABİLİR VEYA ONU İMPLEMENTE EDEN BİR NESNE  OLABİLİR DEMEKTİR.
        //new() dedik yani burda güzel bi kurnazlık var o da şu ==INTERFACELER NEWLENEMEZ VE BUNU KULLANARAK. SADECE IMPLEMENET ALAN NESNELER YAZILABİLİR HALE GELDİ
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtre=null ====filtre vermesen de olur  demek
        T Get(Expression<Func<T, bool>> filter);//nullu sildik şimdi bütün hepsini verir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
