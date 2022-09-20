using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        //cacheye bir şey ekleyebiliriz.
        void Add(string key, object value,int duration);//duration ne kadar süre duracağını söylemek için 
        T Get<T>(string key);//ne döndüreceğimizi Get içinde söyleyeceğiz. sana key vereceğiz sen bize keye denk gelen value'yi ver 
        object Get(string key);

        bool IsAdded(string key);//cachede var mı yok mu diye kontrol edeceğiz yoksa databaseden gelecek varsa cacheden döndüreceğiz.
        void Remove(string key);
        void RemoveByPattern(string pattern);//örneğin içinde get olanları uçur, içinde categoryid olanları uçur gibi.


    }
}
